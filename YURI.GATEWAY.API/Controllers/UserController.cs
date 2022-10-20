using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.APLICACION.CRUD_Usuario.Crear;
using YURI.PRESENTADORES;

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
        public async Task<string> RegistarUsuario(CrearUsuarioParam usuarioParam)
        {
            CrearUsuarioPresenter Presenter = new CrearUsuarioPresenter();
            await Mediator.Send(new CrearUsuarioInputPort(usuarioParam, Presenter));
            return Presenter.Content;
        }

    }
}
