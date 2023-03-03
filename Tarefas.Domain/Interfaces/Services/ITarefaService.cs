using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Contracts;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Services
{
    public interface ITarefaService
    {
        Task<IEnumerable<Tarefa>> GetAllAsync(CancellationToken cancellationToken);
        Task<TarefaDto> CreateTarefaAsync(TarefaCreateDto tarefaDto, CancellationToken cancellationToken);
        Task<TarefaDto> UpdateTarefaAsync(TarefaUpdateDto tarefaDto, CancellationToken cancellationToken);
        Task DeleteTarefaAsync(int tarefaId, CancellationToken cancellationToken);

    }
}
