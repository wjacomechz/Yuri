using Microsoft.EntityFrameworkCore;
using YURI.CQRS.QUERY.DTOs.Seguridades;

namespace YURI.CQRS.QUERY.SQLSERVER.Models.Seguridades
{
    public sealed partial class JCHNETSeguridadesQueryContext
    {
        internal IEnumerable<UsuarioResultQueryDto> ConsultarUsuarios(string codaplicacion, string filtro)
        {
            List<UsuarioResultQueryDto> result = UsuarioResultQueryDto.FromSqlRaw("QRY_Usuarios @p0,@p1", codaplicacion, filtro).ToList();
            return result;
        }
    }
}
