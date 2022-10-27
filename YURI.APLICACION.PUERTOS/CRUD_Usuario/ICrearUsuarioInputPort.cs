using YURI.APLICACION.DTOs.CRUD_Usuario;

namespace YURI.APLICACION.PUERTOS.CRUD_Usuario
{
    public interface ICrearUsuarioInputPort
    {
        Task Handle(CrearUsuarioParam usuario);
    }
}
