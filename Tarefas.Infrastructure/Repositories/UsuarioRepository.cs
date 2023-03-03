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

namespace Tarefas.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly RepositoryDbContext _context;
        public UsuarioRepository(RepositoryDbContext context) => _context = context;

        public async Task<IEnumerable<Usuario>> GetAsync(CancellationToken cancellationToken)
            => await _context.Usuarios.ToListAsync(cancellationToken);

        public async Task<IEnumerable<Usuario>> GetAsync(Expression<Func<Usuario, bool>> condition, CancellationToken cancellationToken)
            => await _context.Usuarios.Where(condition).ToListAsync();

        public async Task<Usuario> GetByIdAsync(int usuarioId, CancellationToken cancellationToken)
            => await _context.Usuarios.FirstAsync(u => u.Id == usuarioId, cancellationToken);

        public async Task<bool> ExistsAsync(Expression<Func<Usuario, bool>> condition, CancellationToken cancellationToken)
            => await _context.Usuarios.AnyAsync(condition, cancellationToken);

        public async Task InsertAsync(Usuario usuario, CancellationToken cancellationToken)
            => await _context.AddAsync(usuario, cancellationToken);

        public async Task DeleteAsync(Usuario usuario)
            => _context.Usuarios.Remove(usuario);

    }
}
