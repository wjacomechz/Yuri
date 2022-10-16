using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.Interfaces.Repositorios;

namespace YURI.APLICACION.MantUsuario
{
    /// <summary>
    /// Tiene la logica del negocio: Mantenimiento de los usuarios del sistema.
    /// </summary>
    internal class CrearUsuarioInteractor : IRequestHandler<CrearUsuarioInputPort, int>
    {
        readonly IUsuarioRepositorio UsuarioRepositorio;
        readonly IUnitOfWork unitOfWork;

        public Task<int> Handle(CrearUsuarioInputPort request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
