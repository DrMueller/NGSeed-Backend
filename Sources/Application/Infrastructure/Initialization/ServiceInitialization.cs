using System;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mmu.Mlh.ApplicationExtensions.Areas.DependencyInjection;
using Mmu.Ngs.WebApi.Areas.Individuals.Services;
using Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Models;
using StructureMap;

namespace Mmu.Ngs.WebApi.Infrastructure.Initialization
{
    internal static class ServiceInitialization
    {
        internal static IServiceProvider InitializeServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper();
            InitializeAppSettings(services, configuration);
            InitializeSecurity(services);
            InitializeCors(services);

            services.AddMvc();

            var result = CreateServiceProvider(services);
            return result;
        }

        private static IServiceProvider CreateServiceProvider(IServiceCollection services)
        {
            var container = ContainerInitializationService.CreateInitializedContainer(typeof(ServiceInitialization).Assembly);
            container.Populate(services);
            var result = container.GetInstance<IServiceProvider>();
            return result;
        }

        private static void InitializeAppSettings(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection(AppSettings.SectionName));
            services.AddSingleton(configuration);
        }

        private static void InitializeCors(IServiceCollection services)
        {
            services.AddCors(
                options =>
                {
                    options.AddPolicy(
                        "All",
                        builder =>
                            builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                .AllowCredentials());
                });
        }

        private static void InitializeSecurity(IServiceCollection services)
        {
            var servicesProvider = CreateServiceProvider(services);
            var securityInitializationService = servicesProvider.GetService<ISecurityInitializationService>();

            securityInitializationService.InitializeSecurity(services);
        }
    }
}