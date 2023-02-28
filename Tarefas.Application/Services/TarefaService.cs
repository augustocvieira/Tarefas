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
        private readonly ITarefaRepository _repository;

        public TarefaService(ITarefaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Tarefa>> ObterTarefasAsync()
        {
            var databaseResult = await _repository.ObterTarefasAsync();
            return databaseResult;
        }
    }
}
