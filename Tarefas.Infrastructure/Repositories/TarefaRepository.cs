using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Application.Interfaces.Repositories;
using Tarefas.Domain.Models;

namespace Tarefas.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        public async Task<IEnumerable<Tarefa>> ObterTarefasAsync()
        {
            Console.WriteLine("Tarefas");
            return new List<Tarefa>();
        }
    }
}