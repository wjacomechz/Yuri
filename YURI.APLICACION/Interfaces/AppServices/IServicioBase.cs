using YURI.DOMINIO.Interfaces;

namespace YURI.APLICACION.Interfaces.AppServices
{
    interface IServicioBase<TEntidad, TEntidadID>
        : IAgregar<TEntidad>, IEditar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>
    {
    }
}
