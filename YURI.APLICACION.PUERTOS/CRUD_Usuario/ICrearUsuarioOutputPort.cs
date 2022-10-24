using YURI.APLICACION.DTOs.Common;

namespace YURI.APLICACION.PUERTOS.CRUD_Usuario
{
    public interface ICrearUsuarioOutputPort
    {
        Task Handle(AppResult resultado);
    }
}
