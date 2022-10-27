using YURI.DOMINIO.ADMINISTRACION.POCOEntidades;

namespace YURI.DOMINIO.ADMINISTRACION.Interfaces
{
    public interface IEmpresaRepositorio
    {
        bool Registrar(Empresa empresa, ref string codigo, ref string mensaje);
    }
}
