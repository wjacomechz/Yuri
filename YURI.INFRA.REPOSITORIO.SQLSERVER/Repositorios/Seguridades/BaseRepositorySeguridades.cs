using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Seguridades
{
    public abstract class BaseRepositorySeguridades
    {
        protected readonly SeguridadesCmdContext jchNetCmdContext;

        internal BaseRepositorySeguridades(SeguridadesCmdContext cmdContext)
        {
            this.jchNetCmdContext = cmdContext;
        }
    }
}
