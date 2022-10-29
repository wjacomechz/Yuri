namespace YURI.DOMINIO.SEGURIDAD.POCOEntidades
{
    public class AtribucionPagina
    {
        public int IdPerfil { get; set; }
        public int IdOpcion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public bool Insertar { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
        public bool Consultar { get; set; }
        public bool Descargar { get; set; }
        public bool AccesoTotal { get; set; }
        public Perfil Perfil { get; set; }
        public Opcion Opcion { get; set; }
        public AtribucionPagina()
        {
            Perfil = new Perfil();
            Opcion = new Opcion();
        }
    }
}
