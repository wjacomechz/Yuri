using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YURI.APLICACION.MantUsuario;

namespace YURI.GATEWAY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IMediator Mediator;

        public UserController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost("RegistrarUsuario")]
        public async Task<ActionResult<int>> RegistarUsuario(CrearUsuarioInputPort usuarioparam)
        {
            return await Mediator.Send(usuarioparam);
        }

    }
}
