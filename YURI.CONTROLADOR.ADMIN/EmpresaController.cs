using Microsoft.AspNetCore.Mvc;
using YURI.APLICACION.DTOs.CRUD_Empresa;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Empresa;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.PRESENTADORES;

namespace YURI.CONTROLADOR.ADMIN
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController
    {
        readonly ICrearEmpresaInputPort InputPortCrearEmpresa;
        readonly ICrearEmpresaOutputPort OutputPortCrearEmpresa;

        public EmpresaController(ICrearEmpresaInputPort inputPortCrearEmpresa,
            ICrearEmpresaOutputPort outputPortCrearEmpresa)
        {
            this.InputPortCrearEmpresa = inputPortCrearEmpresa;
            this.OutputPortCrearEmpresa = outputPortCrearEmpresa;
        }

        [HttpPost("registrar-empresa")]
        public async Task<string> RegistarEmpresa(CrearEmpresaParam empresaParam)
        {
            await this.InputPortCrearEmpresa.Handle(empresaParam);
            var presentador = OutputPortCrearEmpresa as CrearEmpresaPresenter;
            return presentador.Content;
        }
    }
}
