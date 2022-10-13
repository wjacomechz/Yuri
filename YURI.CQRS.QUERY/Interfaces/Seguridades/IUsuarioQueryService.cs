using YURI.CQRS.QUERY.DTOs.Seguridades;

namespace YURI.CQRS.QUERY.Interfaces.Seguridades
{
    public interface IUsuarioQueryService
    {
        IEnumerable<UsuarioResultQueryDto> ConsultarUsuarios(string codAplicacion, string filtro, ref string mensaje);
    }
}
