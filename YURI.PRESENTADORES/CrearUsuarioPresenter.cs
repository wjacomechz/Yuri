using YURI.APLICACION.DTOs.Common;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.PRESENTADORES
{
    public class CrearUsuarioPresenter : IPresenters<AppResponse, string>
    {
        public string Content { get; private set; }

        public CrearUsuarioPresenter()
        {
            Content = string.Empty;
        }

        public void Handle(AppResponse response)
        {
            string mensaje = string.Empty;
            Content = JCHNETConversions.SerializeJson(response, ref mensaje);
        }
    }
}
