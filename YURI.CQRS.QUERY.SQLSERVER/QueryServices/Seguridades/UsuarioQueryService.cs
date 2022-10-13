using Microsoft.Extensions.DependencyInjection;
using YURI.CQRS.QUERY.DTOs.Seguridades;
using YURI.CQRS.QUERY.Interfaces.Seguridades;
using YURI.CQRS.QUERY.SQLSERVER.Models.Seguridades;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.CQRS.QUERY.SQLSERVER.QueryServices.Seguridades
{
    
    public class UsuarioQueryService : BaseSeguridadesQueryService, IUsuarioQueryService
    {

        public UsuarioQueryService(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
        }

        public IEnumerable<UsuarioResultQueryDto> ConsultarUsuarios(string codAplicacion, string filtro, ref string mensaje)
        {
            try
            {
                using (var scope = serviceScopeFactory.CreateScope())
                {
                    using (var axQueryContext = scope.ServiceProvider.GetRequiredService<JCHNETSeguridadesQueryContext>())
                    {
                        return axQueryContext.ConsultarUsuarios(codAplicacion, filtro);
                    };
                };
            }
            catch (Exception ex)
            {
                mensaje = JCHNETConversions.ExceptionToString(ex);
                return null;
            }
        }

       
    }

}
