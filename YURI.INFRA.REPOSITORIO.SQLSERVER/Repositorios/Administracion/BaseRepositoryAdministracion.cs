using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Administracion;

namespace YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Administracion
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
