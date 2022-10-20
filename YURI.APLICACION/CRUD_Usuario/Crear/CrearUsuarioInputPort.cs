using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.APLICACION.Common.Ports;
using YURI.APLICACION.DTOs.Common;
using YURI.APLICACION.DTOs.CRUD_Usuario;

namespace YURI.APLICACION.CRUD_Usuario.Crear
{
    public class CrearUsuarioInputPort : IInputPort<CrearUsuarioParam, AppResponse>
    {
        public CrearUsuarioParam RequestData { get; }

        public IOutputPort<AppResponse> OutputPort { get; }

        public CrearUsuarioInputPort(CrearUsuarioParam requestData, IOutputPort<AppResponse> outputPort)
        {
            RequestData = requestData;
            OutputPort = outputPort;
        }

    }
}
