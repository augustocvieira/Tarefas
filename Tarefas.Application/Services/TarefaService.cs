using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Models;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TarefaService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<Tarefa>> GetAllAsync()
        {
            var repo = _repositoryManager.TarefaRepository;
            var databaseResult = await repo.ObterTarefasAsync();
            return databaseResult;
        }
    }
}
