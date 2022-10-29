using Microsoft.Data.SqlClient;
using System.Data;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.REPOSITORIO.SQLSERVER.Utilidades
{
    public static class UtilitiesSQL
    {
        public static (string, List<SqlParameter>) BuilSql(string NameSp, object[] parameters, bool outupParam)
        {
            int totalParams = 0;
            var param = new List<SqlParameter>();
            foreach (var p in parameters)
            {
                param.Add(new SqlParameter("@p" + param.Count, JCHNETConversions.NothingEmptyToDBNULL(p)));
            }
            if (outupParam)
            {
                param.Add(new SqlParameter() { ParameterName = "@p" + param.Count, SqlDbType = SqlDbType.SmallInt, Direction = ParameterDirection.Output });
                totalParams = param.Count - 1;
            }
            else
            {
                totalParams = param.Count;
            }
            string commandText = $"{NameSp} ";

            for (var i = 0; i < totalParams; i++) commandText += $"@p{i},";
            if (outupParam)
            {
                commandText += $"@p{param.Count - 1} OUTPUT";
            }
            else
            {
                commandText = commandText.Remove(commandText.Length - 1, 1);
            }

            return (commandText, param);
        }

        public static (string, List<SqlParameter>) BuilSql(string NameSp, object[] parameters, SqlParameter[] parameters_out)
        {
            int cont = 0;
            var param = new List<SqlParameter>();
            string commandText = $"{NameSp} ";
            foreach (var p in parameters)
            {
                param.Add(new SqlParameter("@p" + param.Count, JCHNETConversions.NothingEmptyToDBNULL(p)));
                commandText += $"@p{cont},";
                cont++;
            }
            foreach (SqlParameter p in parameters_out)
            {
                param.Add(new SqlParameter() { ParameterName = p.ParameterName, Size = p.Size, Direction = ParameterDirection.Output });
                commandText += $"{p.ParameterName} OUTPUT,";
            }
            commandText = commandText.Substring(0, commandText.Length - 1);
            return (commandText, param);
        }

        public static object GetOutParameter(this List<SqlParameter> param, int index)
        {
            return JCHNETConversions.DBNullToNothing(param.ElementAt(index).Value);
        }
    }
}
