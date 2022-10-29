using YURI.REPOSITORIO.SQLSERVER.Modelos.Administracion;

namespace YURI.REPOSITORIO.SQLSERVER.Repositorios.Administracion
{
    public abstract class BaseRepositoryAdministracion
    {
        protected readonly AdministracionCmdContext jchNetCmdContext;

        internal BaseRepositoryAdministracion(AdministracionCmdContext cmdContext)
        {
            this.jchNetCmdContext = cmdContext;
        }
    }
}
