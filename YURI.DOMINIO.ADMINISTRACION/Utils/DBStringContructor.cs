
namespace YURI.DOMINIO.ADMINISTRACION.Utils
{
    public record DBStringConstructor
    {
        public string server;
        public string database;
        public string user;
        public string password;
        public DBStringConstructor(string Server, string Database, string User, string Password)
            => (server, database, user, password) = (Server, Database, User, Password);

        public static implicit operator string(DBStringConstructor DBC) =>
            $"Data Source={DBC.server};" +
            $"Initial Catalog={DBC.database};" +
            $"User ID={DBC.user};" +
            $"Password={DBC.password};" +
            $"Persist Security Info=True;" +
            $"TrustServerCertificate=True;" +
            $"MultipleActiveResultSets=true;" +
            $"Connection Timeout=180;";

    }
}
