namespace YURI.CQRS.QUERY.DTOs.Seguridades
{
    public sealed class UsuarioResultQueryDto
    {
        public long Id { get; set; }
        public short IdTipoUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public short IntentosLogin { get; set; }
        public bool Bloqueado { get; set; }
        public bool SesionAbierta { get; set; }
        public bool ActualizarDatos { get; set; }
        public DateTime UltimoLogin { get; set; }
        public string Estado { get; set; }
        public UsuarioResultQueryDto()
        {
            TipoUsuario = string.Empty;
            NombreCompleto = string.Empty;
            Alias = string.Empty;
            Email = string.Empty;
            IntentosLogin = 0;
            Estado = string.Empty;
        }
    }
}
