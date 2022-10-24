using FluentValidation;
using YURI.APLICACION.Common.Validators;
using YURI.APLICACION.DTOs.Common;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.APLICACION.CRUD_Usuario
{
    /// <summary>
    /// Tiene la logica del negocio: Mantenimiento de los usuarios del sistema.
    /// </summary>
    public class CrearUsuarioInteractor : ICrearUsuarioInputPort
    {
        readonly ICrearUsuarioOutputPort OutputPort;
        readonly IUsuarioRepositorio UsuarioRepositorio;
        readonly IEnumerable<IValidator<CrearUsuarioParam>> Validators;
        readonly IUnitOfWork unitOfWork;

        public CrearUsuarioInteractor(IUsuarioRepositorio usuarioRepositorio,
            ICrearUsuarioOutputPort crearUsuarioOutputPort,
            IEnumerable<IValidator<CrearUsuarioParam>> validators)
        {
            UsuarioRepositorio = usuarioRepositorio;
            OutputPort = crearUsuarioOutputPort;
            Validators = validators;
        }

        public async Task Handle(CrearUsuarioParam usuario)
        {
            AppResult respuesta = new AppResult();
            try
            {
                await Validator<CrearUsuarioParam>.Validate(usuario, Validators);
                var ClaveEncriptada = JCHNETCyrpto.CifrarClave(usuario.Pass, DomainConstants.JCHNET_KEYENCRIPTA);
                Usuario dm_usuario = new Usuario()
                {
                    IdTipoUsuario = usuario.IdTipoUsuario,
                    Alias = usuario.Alias,
                    Email = usuario.Email,
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
            await OutputPort.Handle(respuesta);
        }


    }
}
