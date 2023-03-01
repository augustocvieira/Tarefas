using System;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Models;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RepositoryDbContext _context;
        public UsuarioRepository(RepositoryDbContext context) => _context = context;
        public async Task InsertAsync(Usuario usuario, CancellationToken token) => await _context.Usuarios.AddAsync(usuario, token);
    }
}
