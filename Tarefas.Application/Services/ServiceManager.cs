using System;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Application.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IStatusService> _lazyStatusService;
    private readonly Lazy<IUsuarioService> _lazyUsuarioService;
    private readonly Lazy<ITarefaService> _lazyTarefaService;

    public ServiceManager(IRepositoryManager repositoryManager)
    {
        _lazyStatusService = new Lazy<IStatusService>(() => new StatusService(repositoryManager));
        _lazyUsuarioService = new Lazy<IUsuarioService>(() => new UsuarioService(repositoryManager));
        _lazyTarefaService = new Lazy<ITarefaService>(() => new TarefaService(repositoryManager));
    }


    public IStatusService StatusService { get; }
    public IUsuarioService UsuarioService { get; }
    public ITarefaService TarefaService { get; }
}