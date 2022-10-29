using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YURI.APLICACION.Common.Validators;
using YURI.APLICACION.CRUD_Empresa;
using YURI.APLICACION.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Empresa;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.DOMINIO.ADMINISTRACION.Interfaces;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.SEGURIDAD.Interfaces;
using YURI.PRESENTADORES;
using YURI.REPOSITORIO.SQLSERVER.Modelos.Administracion;
using YURI.REPOSITORIO.SQLSERVER.Modelos.Seguridad;
using YURI.REPOSITORIO.SQLSERVER.Repositorios.Administracion;
using YURI.REPOSITORIO.SQLSERVER.Repositorios.Seguridad;
using YURI.TRANSVERSAL.COMMON;

namespace YURI.IoC
{
    public static class DependencyContainer
    {
        /// <summary>
        /// Centralizamos las dependencias del proyecto.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddYuriServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var mensaje = string.Empty;
            #region Inicializacion de contextos DB - JCHNET SEGURIDADES
            var JCHNET_SEGURIDADES_CadenaConexion = configuration.GetConnectionString("JCHNETSeguridades");
            if (JCHNET_SEGURIDADES_CadenaConexion == null) throw new Exception("Cadena de conexión SEGURIDADES inválida");
            var JCHNET_ADMINISTRACION_CadenaConexion = configuration.GetConnectionString("JCHNETAdministracion");
            if (JCHNET_ADMINISTRACION_CadenaConexion == null) throw new Exception("Cadena de conexión ADMINISTRACION inválida");
            #endregion
            #region Inyeccion de contextos DB
            services.AddDbContext<SeguridadCmdContext>(options => options.UseSqlServer(JCHNET_SEGURIDADES_CadenaConexion));
            services.AddDbContext<AdministracionCmdContext>(options => options.UseSqlServer(JCHNET_ADMINISTRACION_CadenaConexion));
            #endregion
            #region Inyeccion de los repositorios
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEmpresaRepositorio, EmpresaRepositorio>();
            #endregion
            #region Validadores para los casos de usos
            services.AddValidatorsFromAssembly(typeof(CrearUsuarioValidator).Assembly);
            services.AddValidatorsFromAssembly(typeof(CrearEmpresaValidator).Assembly);
            #endregion
            #region Puertos Entrada
            services.AddScoped<ICrearUsuarioInputPort, CrearUsuarioInteractor>();
            services.AddScoped<ICrearEmpresaInputPort, CrearEmpresaInteractor>();
            #endregion
            #region Puertos Salida
            services.AddScoped<ICrearUsuarioOutputPort, CrearUsuarioPresenter>();
            services.AddScoped<ICrearEmpresaOutputPort, CrearEmpresaPresenter>();
            #endregion
            return services;
        }


    }
}
