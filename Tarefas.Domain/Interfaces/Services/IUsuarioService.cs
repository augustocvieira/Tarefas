using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Contracts;

namespace Tarefas.Domain.Interfaces.Services;

public interface IUsuarioService
{
    Task<UsuarioDto> SignUpAsync(UsuarioSignUpDto usuarioDto, CancellationToken cancellationToken);
    Task<UsuarioDto> SignInAsync(UsuarioSignInDto usuarioDto, CancellationToken cancellationToken);
}