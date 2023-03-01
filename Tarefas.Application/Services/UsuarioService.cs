using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IRepositoryManager _repositoryManager;

    public UsuarioService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}