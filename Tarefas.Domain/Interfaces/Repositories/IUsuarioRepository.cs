using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task InsertAsync(Usuario usuario, CancellationToken token);
}