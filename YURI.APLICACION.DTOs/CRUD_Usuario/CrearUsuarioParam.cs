namespace YURI.APLICACION.DTOs.CRUD_Usuario
{
    public class CrearUsuarioParam
    {
        public short IdTipoUsuario { get; set; }
        public string Alias { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }

        public CrearUsuarioParam()
        {
            Alias = string.Empty;
            Pass = string.Empty;
            Email = string.Empty;
        }
    }
}
