using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mapster;
using Tarefas.Application.Exceptions;
using Tarefas.Domain.Contracts;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;
using Tarefas.Domain.Models;

namespace Tarefas.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IRepositoryManager _repositoryManager;

    public UsuarioService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public async Task<UsuarioDto> SignUpAsync(UsuarioSignUpDto usuarioDto, CancellationToken cancellationToken)
    {
        if(await _repositoryManager.UsuarioRepository.ExistsAsync(usuario => usuario.Login.Equals(usuarioDto.Login), cancellationToken))
            throw new SignUpException("Usuario já cadastrado.");

        if (!string.Equals(usuarioDto.Senha, usuarioDto.RepitaSenha))
            throw new SignUpException("Senha informada não condiz com sua confirmação.");

        var usuario = usuarioDto.Adapt<Usuario>();

        await _repositoryManager.UsuarioRepository.InsertAsync(usuario, cancellationToken);
        await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

        return usuario.Adapt<UsuarioDto>();
    }

    public async Task<UsuarioDto> SignInAsync(UsuarioSignInDto usuarioDto, CancellationToken cancellationToken)
    {
        if (!await _repositoryManager.UsuarioRepository.ExistsAsync(usuario => usuario.Login.Equals(usuarioDto.Login), cancellationToken))
            throw new SignInException("Usuário e/ou senha inválidos");

        var usuario =
            (await _repositoryManager.UsuarioRepository.GetAsync(usuario => usuario.Login.Equals(usuarioDto.Login),
                cancellationToken))
            .First();

        if (!usuario.Senha.Equals(usuarioDto.Login))
            throw new SignInException("Usuário e/ou senha inválidos");


        return usuario.Adapt<UsuarioDto>();

    }


}