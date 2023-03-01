using System;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Application.Services;

public sealed class ServiceManager : IServiceManager
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


    public IStatusService StatusService => _lazyStatusService.Value;
    public IUsuarioService UsuarioService => _lazyUsuarioService.Value;
    public ITarefaService TarefaService => _lazyTarefaService.Value;
}