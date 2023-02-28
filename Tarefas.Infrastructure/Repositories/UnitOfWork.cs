using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly RepositoryDbContext _dbContext;

    public UnitOfWork(RepositoryDbContext dbContext) => _dbContext = dbContext;

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
        _dbContext.SaveChangesAsync(cancellationToken);
}