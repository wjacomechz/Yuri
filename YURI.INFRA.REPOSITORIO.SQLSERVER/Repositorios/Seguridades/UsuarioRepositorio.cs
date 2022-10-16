using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Seguridades
{
    public sealed class UsuarioRepositorio : BaseRepositorySeguridades, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SeguridadesCmdContext cmdContext) : base(cmdContext)
        {
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            try
            {
                string codretorno = string.Empty;
                string mensajeretorno = string.Empty;
                this.jchNetCmdContext.Insert_Usuario(usuario, ref codretorno, ref mensajeretorno);

                return true;
               
            }
            catch (SqlException ex)
            {
                //if (ex.State == 10)
                //    throw new DWException(ex.Message);
                //mensaje = DWConversions.ExceptionToString(ex);
                return false;
            }
            catch (Exception ex)
            {
                //mensaje = DWConversions.ExceptionToString(ex);
                return false;
            }
        }
    }
}
