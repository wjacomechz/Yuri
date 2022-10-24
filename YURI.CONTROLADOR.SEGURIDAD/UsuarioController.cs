using MediatR;
using Microsoft.AspNetCore.Mvc;
using YURI.APLICACION.CRUD_Usuario.Crear;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.PRESENTADORES;

namespace YURI.CONTROLADOR.SEGURIDAD
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {
        readonly IMediator Mediator;

        public UsuarioController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost("registrar-usuario")]
        public async Task<string> RegistarUsuario(CrearUsuarioParam usuarioParam)
        {
            CrearUsuarioPresenter Presenter = new CrearUsuarioPresenter();
            await Mediator.Send(new CrearUsuarioInputPort(usuarioParam, Presenter));
            return Presenter.Content;
        }
    }
}