namespace YURI.APLICACION.DTOs.MantUsuario
{
    public class UsuarioParam
    {
        public short IdTipoUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Alias { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }

        public UsuarioParam()
        {
            NombreCompleto = string.Empty;
            Alias = string.Empty;
            Pass = string.Empty;
            Email = string.Empty;
        }
    }
}
