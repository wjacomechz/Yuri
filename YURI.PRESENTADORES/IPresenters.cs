using YURI.APLICACION.Common.Ports;

namespace YURI.PRESENTADORES
{
    /// <summary>
    /// Toma la informacion devuelto la capa de aplicacion y formatearla a la interfaz de usuario.
    /// </summary>
    public interface IPresenters<ResponseType, FormatType> : IOutputPort<ResponseType>
    {
        public FormatType Content { get; }
    }
}