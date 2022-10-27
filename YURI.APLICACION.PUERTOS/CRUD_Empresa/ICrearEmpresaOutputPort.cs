using YURI.APLICACION.DTOs.Common;

namespace YURI.APLICACION.PUERTOS.CRUD_Empresa
{
    public interface ICrearEmpresaOutputPort
    {
        Task Handle(AppResult resultado);
    }
}
