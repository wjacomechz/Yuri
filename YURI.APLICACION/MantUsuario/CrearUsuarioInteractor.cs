using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.APLICACION.MantUsuario
{
    /// <summary>
    /// Tiene la logica del negocio: Mantenimiento de los usuarios del sistema.
    /// </summary>
    public class CrearUsuarioInteractor : IRequestHandler<CrearUsuarioInputPort, int>
    {
        readonly IUsuarioRepositorio UsuarioRepositorio;
        readonly IUnitOfWork unitOfWork;

        public CrearUsuarioInteractor(IUsuarioRepositorio usuarioRepositorio)
        {
            this.UsuarioRepositorio = usuarioRepositorio;
        }

        public async Task<int> Handle(CrearUsuarioInputPort request, CancellationToken cancellationToken)
        {
            int returncode = 0;
            try
            {
                var ClaveEncriptada = JCHNETCyrpto.CifrarClave(request.Pass, DomainConstants.JCHNET_KEYENCRIPTA);
                Usuario dm_usuario = new Usuario()
                {
                    IdTipoUsuario = 1,
                    NombreCompleto = "admin 3",
                    Alias = "admin 3",
                    Email = "william.jacome@gmail.com",
                    Pass = ClaveEncriptada
                };
                UsuarioRepositorio.RegistrarUsuario(dm_usuario);
                returncode = 1;
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al registrar un nuevo usuario en el sistema.", ex.Message);
            }
            return returncode;
        }
    }
}
