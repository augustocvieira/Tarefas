using Microsoft.EntityFrameworkCore;

namespace Tarefas.Infrastructure.Context;

public class Context : DbContext
{
    
    public Context(DbContextOptions options) : base(options)
    {
    }
}