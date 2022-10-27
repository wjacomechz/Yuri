using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Excepciones;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Seguridades
{
    public sealed class UsuarioRepositorio : BaseRepositorySeguridades, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SeguridadesCmdContext cmdContext) : base(cmdContext)
        {
        }

        public bool RegistrarUsuario(Usuario usuario, ref string codigo, ref string mensaje)
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
