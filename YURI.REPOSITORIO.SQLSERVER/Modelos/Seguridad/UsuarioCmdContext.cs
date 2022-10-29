using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using YURI.DOMINIO.SEGURIDAD.POCOEntidades;
using YURI.REPOSITORIO.SQLSERVER.Utilidades;

namespace YURI.REPOSITORIO.SQLSERVER.Modelos.Seguridad
{
    public sealed partial class SeguridadCmdContext
    {
        internal bool Insert_Usuario(Usuario dm_usuario, ref string codretorno, ref string mensajeretorno)
        {
            string namesp = "INS_Usuario";
            object[] parameters = new object[] {
                dm_usuario.IdTipoUsuario,
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
            (CommandText, param) = UtilitiesSQL.BuilSql(namesp, parameters, parameters_out);
            Database.ExecuteSqlRaw(CommandText, param);
            codretorno = param.GetOutParameter(param.FindIndex(x => x.ParameterName == "@codigoRetorno")).ToString();
            mensajeretorno = param.GetOutParameter(param.FindIndex(x => x.ParameterName == "@mensajeRetorno")).ToString();
            return true;
        }
    }
}
