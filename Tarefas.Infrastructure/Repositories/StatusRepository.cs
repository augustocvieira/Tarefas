using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories;

public class StatusRepository : IStatusRepository
{
    private readonly RepositoryDbContext _context;
    public StatusRepository(RepositoryDbContext context) => _context = context;
}