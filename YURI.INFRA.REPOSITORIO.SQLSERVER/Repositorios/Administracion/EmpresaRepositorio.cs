using Microsoft.Data.SqlClient;
using YURI.DOMINIO.ADMINISTRACION.Constants;
using YURI.DOMINIO.ADMINISTRACION.Excepciones;
using YURI.DOMINIO.ADMINISTRACION.Interfaces;
using YURI.DOMINIO.ADMINISTRACION.POCOEntidades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Administracion;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Administracion
{
    public class EmpresaRepositorio : BaseRepositoryAdministracion, IEmpresaRepositorio
    {
        public EmpresaRepositorio(AdministracionCmdContext cmdContext) : base(cmdContext)
        {
        }

        public bool Registrar(Empresa empresa, ref string codigo, ref string mensaje)
        {
            try
            {
                return this.jchNetCmdContext.Insert_Empresa(empresa, ref codigo, ref mensaje);
            }
            catch (SqlException ex)
            {
                if (ex.State == 10)
                    throw new GeneralException("Error tecnico db.", ex.Message);
                codigo = DomainEnumExtensions.DenialGetString(DenialLevel.ErrorTecnicoSQL);
                mensaje = JCHNETConversions.ExceptionToString(ex);
                return false;
            }
            catch (Exception ex)
            {
                codigo = DomainEnumExtensions.DenialGetString(DenialLevel.ErrorNoDefinido);
                mensaje = JCHNETConversions.ExceptionToString(ex);
                return false;
            }
        }
    }
}
