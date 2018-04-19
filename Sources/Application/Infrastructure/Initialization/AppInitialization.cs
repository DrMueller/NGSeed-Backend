using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Mmu.Ngs.WebApi.Infrastructure.Middlewares;
using Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services;
using NLog.Extensions.Logging;
using NLog.Web;

namespace Mmu.Ngs.WebApi.Infrastructure.Initialization
{
    internal static class AppInitialization
    {
        internal static void InitializeApplication(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            IConfigurationRoot configurationRoot)
        {
            InitializeMiddlewares(app);
            InitializeCors(app);
            InitializeNlog(env, loggerFactory);

            app.UseAuthentication();
            app.UseMvc();
        }

        private static void InitializeCors(IApplicationBuilder app)
        {
            app.UseCors("All");
        }

        private static void InitializeMiddlewares(IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();
        }

        private static void InitializeNlog(IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddNLog();
            env.ConfigureNLog("nlog.config");
        }
    }
}