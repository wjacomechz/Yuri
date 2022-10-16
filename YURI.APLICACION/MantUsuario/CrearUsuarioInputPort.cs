using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.APLICACION.DTOs.MantUsuario;

namespace YURI.APLICACION.MantUsuario
{
    public class CrearUsuarioInputPort : UsuarioParam, IRequest<int>
    {
    }
}
