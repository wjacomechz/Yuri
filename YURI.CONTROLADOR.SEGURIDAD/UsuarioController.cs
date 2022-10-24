using Microsoft.AspNetCore.Mvc;
using YURI.APLICACION.CRUD_Usuario;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.PRESENTADORES;

namespace YURI.CONTROLADOR.SEGURIDAD
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController
    {
        readonly ICrearUsuarioInputPort InputPortCrearUsuario;
        readonly ICrearUsuarioOutputPort OutputPortCrearUsuario;

        public UsuarioController(ICrearUsuarioInputPort inputPortCrearUsuario,
            ICrearUsuarioOutputPort outputPortCrearUsuario)
        {
            this.InputPortCrearUsuario = inputPortCrearUsuario;
            this.OutputPortCrearUsuario = outputPortCrearUsuario;
        }

        [HttpPost("registrar-usuario")]
        public async Task<string> RegistarUsuario(CrearUsuarioParam usuarioParam)
        {
            await this.InputPortCrearUsuario.Handle(usuarioParam);
            var presentador = OutputPortCrearUsuario as CrearUsuarioPresenter;
            return presentador.Content;
        }
    }
}