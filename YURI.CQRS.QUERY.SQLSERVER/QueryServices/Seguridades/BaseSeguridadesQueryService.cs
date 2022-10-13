using Microsoft.Extensions.DependencyInjection;

namespace YURI.CQRS.QUERY.SQLSERVER.QueryServices.Seguridades
{
    public abstract class BaseSeguridadesQueryService
    {
        protected readonly IServiceScopeFactory serviceScopeFactory;

        internal BaseSeguridadesQueryService(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }
    }

}
