using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.DOMINIO.Interfaces
{
    public interface IEliminar<TEntidadID>
    {
        void Eliminar(TEntidadID entidadId);
    }
}
