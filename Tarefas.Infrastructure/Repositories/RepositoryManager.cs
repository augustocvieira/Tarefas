using System;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories;

public class RepositoryManager : IRepositoryManager
{

    private readonly Lazy<IUsuarioRepository> _lazyUsuarioRepository;
    private readonly Lazy<IStatusRepository> _lazyStatusRepository;
    private readonly Lazy<ITarefaRepository> _lazyTarefaRepository;
    private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

    public RepositoryManager(RepositoryDbContext dbContext)
    {
        _lazyStatusRepository = new Lazy<IStatusRepository>(() => new StatusRepository(dbContext));
        _lazyUsuarioRepository = new Lazy<IUsuarioRepository>(() => new UsuarioRepository(dbContext));
        _lazyTarefaRepository = new Lazy<ITarefaRepository>(() => new TarefaRepository(dbContext));
        _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(dbContext));
    }

    public IUsuarioRepository UsuarioRepository => _lazyUsuarioRepository.Value;
    public IStatusRepository StatusRepository => _lazyStatusRepository.Value;
    public ITarefaRepository TarefaRepository => _lazyTarefaRepository.Value;
    public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;


}