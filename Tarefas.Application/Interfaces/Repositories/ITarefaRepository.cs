using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Application.Interfaces.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> ObterTarefasAsync();
    }
}