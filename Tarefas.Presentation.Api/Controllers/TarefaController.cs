using Microsoft.AspNetCore.Mvc;
using Tarefas.Application.Interfaces.Services;

namespace Tarefas.Presentation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaService _service;

        public TarefaController(ITarefaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.ObterTarefasAsync();
            return Ok(result);
        }
    }
}