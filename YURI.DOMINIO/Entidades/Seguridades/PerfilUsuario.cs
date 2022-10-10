namespace YURI.DOMINIO.Entidades.Seguridades
{
    public sealed class PerfilUsuario
    {
        public long IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public Usuario Usuario { get; set; }
        public Perfil Perfil { get; set; }
        public PerfilUsuario()
        {
            Usuario = new Usuario();
            Perfil = new Perfil();
        }
    }
}
