using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Application.Interfaces.Repositories;
using Tarefas.Application.Interfaces.Services;
using Tarefas.Domain.Models;

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
