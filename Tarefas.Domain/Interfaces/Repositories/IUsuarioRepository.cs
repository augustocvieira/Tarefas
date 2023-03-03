using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task<IEnumerable<Usuario>> GetAsync(CancellationToken cancellationToken);
    Task<Usuario> GetByIdAsync(int usuarioId, CancellationToken cancellationToken);
    Task<IEnumerable<Usuario>> GetAsync(Expression<Func<Usuario, bool>> condition, CancellationToken cancellationToken);
    Task<bool> ExistsAsync(Expression<Func<Usuario, bool>> condition, CancellationToken cancellationToken);
    Task InsertAsync(Usuario usuario, CancellationToken cancellationToken);
    Task DeleteAsync(Usuario usuario);
}