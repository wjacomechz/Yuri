namespace YURI.DOMINIO.SEGURIDAD.POCOEntidades
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool HabilitadoClientes { get; set; }
        public string IndexControlador { get; set; }
        public string IndexPag { get; set; }
        public string IconoBoard { get; set; }
        public string StyleBoard { get; set; }
        public string Estado { get; set; }
        public Perfil()
        {
            Nombre = string.Empty;
            IndexControlador = string.Empty;
            IconoBoard = string.Empty;
            StyleBoard = string.Empty;
            Estado = string.Empty;
            IndexPag = string.Empty;
        }
    }
}
