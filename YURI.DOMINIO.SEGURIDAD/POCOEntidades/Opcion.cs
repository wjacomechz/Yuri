namespace YURI.DOMINIO.SEGURIDAD.POCOEntidades
{
    public class Opcion
    {
        public int Id { get; set; }
        public int IdModulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Icono { get; set; }
        public string Url { get; set; }
        public string NombreControlador { get; set; }
        public string NombreAccion { get; set; }
        public string Estado { get; set; }
        public bool MostrarAside { get; set; }
        public Modulo Modulo { get; set; }
        public Opcion()
        {
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Icono = string.Empty;
            Url = string.Empty;
            NombreControlador = string.Empty;
            NombreAccion = string.Empty;
            Estado = string.Empty;
            Modulo = new Modulo();
        }
    }
}
