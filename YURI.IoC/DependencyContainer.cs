using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YURI.APLICACION.Common.Validators;
using YURI.APLICACION.CRUD_Empresa;
using YURI.APLICACION.CRUD_Usuario;
using YURI.APLICACION.PUERTOS.CRUD_Empresa;
using YURI.APLICACION.PUERTOS.CRUD_Usuario;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Seguridades;
using YURI.PRESENTADORES;
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
            var JCHNET_SEGURIDADES_DataSource = "localhost";
            var JCHNET_SEGURIDADES_InitialCatalog = "JCHNET_SEGURIDADES";
            var JCHNET_SEGURIDADES_UserId = "sa";
            var JCHNET_SEGURIDADES_CadenaConexion = JCHNETUtilities.CadenaConexion(JCHNET_SEGURIDADES_DataSource,
                                JCHNET_SEGURIDADES_InitialCatalog,
                                JCHNET_SEGURIDADES_UserId,
                                "K6Ek7dLF5QPfcaQ2TYbXfA==",//settings.MEGADB.Password,
                                DomainConstants.JCHNET_KEYENCRIPTA,
                                ref mensaje);
            if (JCHNET_SEGURIDADES_CadenaConexion == null) throw new Exception("Cadena de conexión SEGURIDADES inválida");
            #endregion

            #region Inyeccion de contextos DB
            services.AddDbContext<SeguridadesCmdContext>(options => options.UseSqlServer(JCHNET_SEGURIDADES_CadenaConexion));
            #endregion
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

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
