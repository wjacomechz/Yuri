namespace YURI.DOMINIO.POCOEntidades.Seguridades
{
    public class TipoUsuario
    {
        public short Id { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public string Codigo { get; set; }

        public TipoUsuario()
        {
            Nombre = string.Empty;
            Codigo = string.Empty;
        }
    }
}
