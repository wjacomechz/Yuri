using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.DOMINIO.POCOEntidades.Seguridades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Utilities;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades
{
    public sealed partial class SeguridadesCmdContext
    {

        internal bool Insert_Usuario(Usuario dm_usuario, ref string codretorno, ref string mensajeretorno)
        {
            string namesp = "INS_Usuario";
            object[] parameters = new object[] {
                dm_usuario.IdTipoUsuario,
                dm_usuario.NombreCompleto,
                dm_usuario.Alias,
                dm_usuario.Pass,
                dm_usuario.Email
            };
            SqlParameter[] parameters_out ={
                new SqlParameter() { ParameterName = "@codigoRetorno", Size = 4 },
                new SqlParameter() { ParameterName = "@mensajeRetorno", Size = 150 }
            };
            string CommandText = string.Empty;
            List<SqlParameter> param = null;
            (CommandText, param) = RepoUtilities.BuilSql(namesp, parameters, parameters_out);
            Database.ExecuteSqlRaw(CommandText, param);
            codretorno = param.GetOutParameter(param.FindIndex(x => x.ParameterName == "@codigoRetorno")).ToString();
            mensajeretorno = param.GetOutParameter(param.FindIndex(x => x.ParameterName == "@mensajeRetorno")).ToString();
            return true;
        }


    }
}
