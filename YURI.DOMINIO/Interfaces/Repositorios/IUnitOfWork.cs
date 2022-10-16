using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.DOMINIO.Interfaces.Repositorios
{
    public interface IUnitOfWork
    {
        Task<int> GuardarCambiosAsync();
    }
}
