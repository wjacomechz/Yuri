using YURI.APLICACION.DTOs.Common;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.PRESENTADORES
{
    public class CrearUsuarioPresenter : ICrearUsuarioOutputPort, IPresenters<string>
    {
        public string Content { get; private set; }

        public CrearUsuarioPresenter()
        {
            Content = string.Empty;
        }

        public Task Handle(AppResult resultado)
        {
            string mensaje = string.Empty;
            Content = JCHNETConversions.SerializeJson(resultado, ref mensaje);
            return Task.CompletedTask;
        }
    }
}
