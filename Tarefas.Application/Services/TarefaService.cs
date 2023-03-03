using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Models;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;
using System.Threading;
using Tarefas.Domain.Contracts;

namespace Tarefas.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TarefaService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<Tarefa>> GetAllAsync(CancellationToken cancellationToken)
        {
            var repo = _repositoryManager.TarefaRepository;
            var databaseResult = await repo.GetAsync(cancellationToken);
            return databaseResult;
        }

        public Task<TarefaDto> CreateTarefaAsync(TarefaCreateDto tarefaDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaDto> UpdateTarefaAsync(TarefaUpdateDto tarefaDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTarefaAsync(int tarefaId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
