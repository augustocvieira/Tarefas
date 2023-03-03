using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Tarefas.Application.Exceptions;
using Tarefas.Domain.Contracts;
using Tarefas.Domain.Interfaces.Services;
using static System.Net.Mime.MediaTypeNames;

namespace Tarefas.Presentation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TarefaController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            try
            {
                var result = await _serviceManager.TarefaService.GetAllAsync(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] TarefaCreateDto tarefaDto, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _serviceManager.TarefaService.CreateTarefaAsync(tarefaDto, cancellationToken);
                return CreatedAtAction(nameof(Post), new {Id = result.Id}, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}