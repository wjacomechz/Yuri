namespace YURI.DOMINIO.ADMINISTRACION.POCOEntidades
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Estado { get; set; }

        public Empresa()
        {
            Identificacion = string.Empty;
            RazonSocial = string.Empty;
            NombreComercial = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Estado = string.Empty;
        }
    }
}
