using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Domain.Models;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly RepositoryDbContext _context;
        public TarefaRepository(RepositoryDbContext context) => _context = context;

        public async Task<IEnumerable<Tarefa>> ObterTarefasAsync()
        {
            Console.WriteLine("Tarefas");
            return new List<Tarefa>();
        }
    }
}