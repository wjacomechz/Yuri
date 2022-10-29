using YURI.REPOSITORIO.SQLSERVER.Modelos.Seguridad;

namespace YURI.REPOSITORIO.SQLSERVER.Repositorios.Seguridad
{
    public abstract class BaseRepositorySeguridad
    {
        protected readonly SeguridadCmdContext jchNetCmdContext;

        internal BaseRepositorySeguridad(SeguridadCmdContext cmdContext)
        {
            this.jchNetCmdContext = cmdContext;
        }
    }
}
