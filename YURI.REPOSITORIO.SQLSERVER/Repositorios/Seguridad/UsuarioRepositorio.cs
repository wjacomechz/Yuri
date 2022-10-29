using Microsoft.Data.SqlClient;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.SEGURIDAD.Interfaces;
using YURI.DOMINIO.SEGURIDAD.POCOEntidades;
using YURI.REPOSITORIO.SQLSERVER.Modelos.Seguridad;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.REPOSITORIO.SQLSERVER.Repositorios.Seguridad
{
    public sealed class UsuarioRepositorio : BaseRepositorySeguridad, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SeguridadCmdContext cmdContext) : base(cmdContext)
        {
        }

        public bool Registrar(Usuario usuario, ref string codigo, ref string mensaje)
        {
            try
            {
                return this.jchNetCmdContext.Insert_Usuario(usuario, ref codigo, ref mensaje);
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
