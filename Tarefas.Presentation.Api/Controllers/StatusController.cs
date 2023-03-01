using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Domain.Interfaces.Repositories;

namespace Tarefas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;

        public StatusController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken token)
        {
            var service = _repositoryManager.StatusRepository;
            var result = await service.GetAll(token);
            return Ok(result);
        }
    }
}
