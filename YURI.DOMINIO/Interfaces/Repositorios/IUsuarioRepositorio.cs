using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.POCOEntidades.Seguridades;

namespace YURI.DOMINIO.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio
    {
        bool RegistrarUsuario(Usuario usuario);
    }
}
