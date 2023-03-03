using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Mapster;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;
using Tarefas.Domain.Contracts;

namespace Tarefas.Application.Services;

public class StatusService : IStatusService
{
    private readonly IRepositoryManager _repositoryManager;

    public StatusService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public async Task<IEnumerable<StatusDto>> GetAllAsync(CancellationToken token)
    {
        var statuses = await _repositoryManager.StatusRepository.GetAsync(token);
        var result = statuses.Adapt<IEnumerable<StatusDto>>();
        return result;
    }
}