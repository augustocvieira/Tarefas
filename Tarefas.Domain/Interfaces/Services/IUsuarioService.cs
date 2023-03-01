using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Contracts;

namespace Tarefas.Domain.Interfaces.Services;

public interface IUsuarioService
{
    Task<UsuarioDto> SignUpAsync(UsuarioSignUpDto usuarioSignUp, CancellationToken token);
    Task<UsuarioDto> SignInAsync(UsuarioSignInDto usuarioSignIn, CancellationToken token);
}