using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Tarefas.Domain.Models;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace Tarefas.Infrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly RepositoryDbContext _context;
        public TarefaRepository(RepositoryDbContext context) => _context = context;

        public async Task<IEnumerable<Tarefa>> GetAsync(CancellationToken cancellationToken)
            => await _context.Tarefas.ToListAsync(cancellationToken);

        public async Task<IEnumerable<Tarefa>> GetAsync(Expression<Func<Tarefa, bool>> condition, CancellationToken cancellationToken) 
            => await _context.Tarefas.Where(condition).ToListAsync(cancellationToken);

        public async Task<bool> ExistsAsync(Expression<Func<Tarefa, bool>> condition, CancellationToken cancellationToken)
            => await _context.Tarefas.AnyAsync(condition, cancellationToken);

        public async Task InsertAsync(Tarefa tarefa, CancellationToken cancellationToken)
            => await _context.Tarefas.AddAsync(tarefa, cancellationToken);

        public async Task DeleteAsync(Tarefa tarefa)
            => _context.Tarefas.Remove(tarefa);

    }
}