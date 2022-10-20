using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YURI.APLICACION.Common.Behaviors;
using YURI.APLICACION.CRUD_Usuario.Crear;
using YURI.DOMINIO.Constants;
using YURI.DOMINIO.Interfaces.Repositorios;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Modelos.Seguridades;
using YURI.INFRA.REPOSITORIO.SQLSERVER.Repositorios.Seguridades;
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

            services.AddMediatR(typeof(CrearUsuarioInteractor));
            services.AddValidatorsFromAssembly(typeof(CrearUsuarioValidator).Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));
            return services;
        }


    }
}
