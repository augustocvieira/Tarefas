using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Models;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories;

public class StatusRepository : IStatusRepository
{
    private readonly RepositoryDbContext _context;
    public StatusRepository(RepositoryDbContext context) => _context = context;

    public async Task<IEnumerable<Status>> GetAsync(CancellationToken token) =>
        await _context.Statuses.ToListAsync(token);

    public async Task<IEnumerable<Status>> GetAsync(Expression<Func<Status, bool>> condtion, CancellationToken cancellationToken)
        => await _context.Statuses.Where(condtion).ToListAsync(cancellationToken);

    public async Task<Status> GetByIdAsync(int statusId, CancellationToken cancellationToken)
        => await _context.Statuses.FirstAsync(s => s.Id == statusId, cancellationToken);

    public async Task<bool> ExistsAsync(Expression<Func<Status, bool>> condition, CancellationToken cancellationToken)
        => await _context.Statuses.AnyAsync(condition, cancellationToken);
}