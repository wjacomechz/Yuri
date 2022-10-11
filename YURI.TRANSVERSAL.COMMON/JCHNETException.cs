namespace YURI.TRANSVERSAL.COMMON
{
    public class JCHNETException : Exception
    {
        public string mensaje { set; get; }

        public JCHNETException(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public JCHNETException(Enum value) : base(value.ToString("D"))
        {
            this.mensaje = string.Empty;
        }
    }
}
