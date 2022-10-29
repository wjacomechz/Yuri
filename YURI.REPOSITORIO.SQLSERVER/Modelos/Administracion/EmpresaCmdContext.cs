using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using YURI.DOMINIO.ADMINISTRACION.POCOEntidades;
using YURI.REPOSITORIO.SQLSERVER.Utilidades;

namespace YURI.REPOSITORIO.SQLSERVER.Modelos.Administracion
{
    public sealed partial class AdministracionCmdContext
    {

        internal bool Insert_Empresa(Empresa empresa, ref string codretorno, ref string mensajeretorno)
        {
            string namesp = "INS_Empresa";
            object[] parameters = new object[] {
                empresa.Identificacion,
                empresa.RazonSocial,
                empresa.NombreComercial,
                empresa.Direccion,
                empresa.Email,
                empresa.Telefono,
                empresa.Celular
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
