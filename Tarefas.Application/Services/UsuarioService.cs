using System;
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

    public async Task<UsuarioDto> SignUpAsync(UsuarioSignUpDto usuarioSignUp, CancellationToken token)
    {
        if (!string.Equals(usuarioSignUp.Senha, usuarioSignUp.RepitaSenha))
            throw new SignUpException("Senha informada não condiz com sua confirmação.");

        var usuario = usuarioSignUp.Adapt<Usuario>();

        await _repositoryManager.UsuarioRepository.InsertAsync(usuario, token);
        await _repositoryManager.UnitOfWork.SaveChangesAsync(token);

        return usuario.Adapt<UsuarioDto>();
    }

    public async Task SignInAsync(UsuarioSignInDto usuarioSignIn)
    {
        throw new NotImplementedException();
    }


}