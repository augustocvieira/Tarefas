using System;
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

        public async Task<bool> ExistsByLoginAsync(string login, CancellationToken token) =>
            await _context.Usuarios.AnyAsync(x => x.Login.Equals(login), token);

        public async Task<Usuario> FindByLoginAsync(string login, CancellationToken token) =>
            await _context.Usuarios.FirstOrDefaultAsync(x => x.Login.Equals(login), token);
        public async Task InsertAsync(Usuario usuario, CancellationToken token) => await _context.Usuarios.AddAsync(usuario, token);
    }
}
