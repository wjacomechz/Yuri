using YURI.APLICACION.DTOs.CRUD_Empresa;

namespace YURI.APLICACION.PUERTOS.CRUD_Empresa
{
    public interface ICrearEmpresaInputPort
    {
        Task Handle(CrearEmpresaParam empresa);
    }
}
