using YURI.DOMINIO.SEGURIDAD.POCOEntidades;

namespace YURI.DOMINIO.SEGURIDAD.Interfaces
{
    public interface IUsuarioRepositorio
    {
        bool Registrar(Usuario usuario, ref string codigo, ref string mensaje);
    }
}
