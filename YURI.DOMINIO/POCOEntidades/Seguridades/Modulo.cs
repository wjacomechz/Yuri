namespace YURI.DOMINIO.POCOEntidades.Seguridades
{
    public sealed class Modulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public string Estado { get; set; }
        public string CodigoAplicacion { get; set; }
        public Modulo()
        {
            Nombre = string.Empty;
            Icono = string.Empty;
            Estado = string.Empty;
            CodigoAplicacion = string.Empty;
        }
    }
}
