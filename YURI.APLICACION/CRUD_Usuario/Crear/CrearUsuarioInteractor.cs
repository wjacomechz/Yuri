using MediatR;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.APLICACION.DTOs.Common;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.APLICACION.CRUD_Usuario.Crear
{
    /// <summary>
    /// Tiene la logica del negocio: Mantenimiento de los usuarios del sistema.
    /// </summary>
    public class CrearUsuarioInteractor : AsyncRequestHandler<CrearUsuarioInputPort>
    {
        readonly IUsuarioRepositorio UsuarioRepositorio;
        readonly IUnitOfWork unitOfWork;

        public CrearUsuarioInteractor(IUsuarioRepositorio usuarioRepositorio)
        {
            UsuarioRepositorio = usuarioRepositorio;
        }

        protected async override Task Handle(CrearUsuarioInputPort request, CancellationToken cancellationToken)
        {
            AppResponse respuesta = new AppResponse();
            try
            {
                var ClaveEncriptada = JCHNETCyrpto.CifrarClave(request.RequestData.Pass, DomainConstants.JCHNET_KEYENCRIPTA);
                Usuario dm_usuario = new Usuario()
                {
                    IdTipoUsuario = request.RequestData.IdTipoUsuario,
                    Alias = request.RequestData.Alias,
                    Email = request.RequestData.Email,
                    Pass = ClaveEncriptada
                };
                UsuarioRepositorio.RegistrarUsuario(dm_usuario);
                respuesta.CodigoRespuesta = "0000";
                respuesta.MensajeRetorno = "Usuario registrado.";
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al registrar un nuevo usuario en el sistema.", ex.Message);
            }
            request.OutputPort.Handle(respuesta);
        }
    }
}
