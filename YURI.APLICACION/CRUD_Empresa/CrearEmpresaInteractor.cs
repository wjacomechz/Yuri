using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.APLICACION.Common.Validators;
using YURI.APLICACION.DTOs.Common;
using YURI.APLICACION.DTOs.CRUD_Empresa;
using YURI.APLICACION.DTOs.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Empresa;
using YURI.DOMINIO.ADMINISTRACION.Interfaces;
using YURI.DOMINIO.ADMINISTRACION.POCOEntidades;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.APLICACION.CRUD_Empresa
{
    /// <summary>
    /// Tiene la logica del negocio: Mantenimiento de los empresas del sistema.
    /// </summary>
    public class CrearEmpresaInteractor : ICrearEmpresaInputPort
    {
        readonly ICrearEmpresaOutputPort OutputPort;
        readonly IEmpresaRepositorio EmpresaRepositorio;
        readonly IEnumerable<IValidator<CrearEmpresaParam>> Validators;

        public CrearEmpresaInteractor(ICrearEmpresaOutputPort outputPort,
            IEmpresaRepositorio repositorio,
            IEnumerable<IValidator<CrearEmpresaParam>> validators)
        {
            OutputPort = outputPort;
            EmpresaRepositorio = repositorio;
            Validators = validators;
        }

        public async Task Handle(CrearEmpresaParam empresa)
        {
            AppResult respuesta = new AppResult();
            try
            {
                await Validator<CrearEmpresaParam>.Validate(empresa, Validators);
                Empresa dm_empresa = new Empresa() { 
                    Identificacion = empresa.Identificacion,
                    RazonSocial = empresa.RazonSocial,
                    Celular = empresa.Celular,
                    Email = empresa.Email,
                    NombreComercial = empresa.NombreComercial,
                    Direccion = empresa.Direccion,
                    Telefono = empresa.Telefono
                };
                string codigo = string.Empty, mensaje = string.Empty;
                EmpresaRepositorio.Registrar(dm_empresa, ref codigo, ref mensaje);
                respuesta.CodigoRespuesta = codigo;
                respuesta.MensajeRetorno = mensaje;
            }
            catch (Exception ex)
            {
                throw new GeneralException("Error al registrar un nuevo usuario en el sistema.", ex.Message);
            }
            await OutputPort.Handle(respuesta);
        }
    }
}
