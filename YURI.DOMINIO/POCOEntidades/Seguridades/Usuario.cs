namespace YURI.DOMINIO.POCOEntidades.Seguridades
{
    public class Usuario
    {
        public long Id { get; set; }
        public short IdTipoUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Alias { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public short IntentosLogin { get; set; }
        public bool Bloqueado { get; set; }
        public bool SesionAbierta { get; set; }
        public bool ActualizarDatos { get; set; }
        public DateTime UltimoLogin { get; set; }
        public bool MostrarFoto { get; set; }
        public string ArchivoFoto { get; set; }
        public string Estado { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        public Usuario()
        {
            NombreCompleto = string.Empty;
            Alias = string.Empty;
            Pass = string.Empty;
            Email = string.Empty;
            ArchivoFoto = string.Empty;
            Estado = string.Empty;
            TipoUsuario = new TipoUsuario();
        }
    }
}
