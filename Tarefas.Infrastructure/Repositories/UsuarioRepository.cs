using System;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RepositoryDbContext _context;
        public UsuarioRepository(RepositoryDbContext context) => _context = context;
    }
}
