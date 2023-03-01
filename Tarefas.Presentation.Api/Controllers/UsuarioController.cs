using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Domain.Contracts;
using Tarefas.Domain.Interfaces.Services;

namespace Tarefas.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UsuarioController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioSignUpDto usuario, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _serviceManager.UsuarioService.SignUpAsync(usuario, cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("signIn")]
        public async Task<IActionResult> SignIn([FromBody] UsuarioSignInDto usuario, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _serviceManager.UsuarioService.SignInAsync(usuario, cancellationToken);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
