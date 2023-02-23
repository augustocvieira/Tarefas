using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Application.Interfaces.Services
{
    public interface ITarefaService
    {
        Task<IEnumerable<Tarefa>> ObterTarefasAsync();
    }
}