using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Mmu.Ngs.WebApi.Infrastructure.Security.NoOpAuthentication;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Models.SubSettings;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Services;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services.Implementation
{
    public class SecurityServiceInitializationService : ISecurityServiceInitializationService
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public SecurityServiceInitializationService(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public void InitializeSecurity(IServiceCollection services)
        {
            var appSettings = _appSettingsProvider.GetAppSettings();
            if (!appSettings.ActivateSecurity)
            {
                InitializeNoOpSecurity(services);
            }
            else
            {
                InitializeAzureJwtSecurity(services, appSettings.AzureAdSettings);
            }
        }

        private static void InitializeAzureJwtSecurity(IServiceCollection services, AzureAdSettings azureAdSettings)
        {
            var authenticationBuidler = services.AddAuthentication(
                options =>
                {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
            );

            authenticationBuidler.AddJwtBearer(
                options =>
                {
                    options.IncludeErrorDetails = true;
                    options.Authority = $"{azureAdSettings.Instance}{azureAdSettings.TenantId}";
                    options.Audience = azureAdSettings.AudienceId;
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                });
        }

        private  static void  InitializeNoOpSecurity(IServiceCollection services)
        {
            services.AddAuthentication(
                options =>
                {
                    options.DefaultScheme = NoOpAuthHandler.NoOpSchema;
                    options.DefaultAuthenticateScheme = NoOpAuthHandler.NoOpSchema;
                    options.DefaultChallengeScheme = NoOpAuthHandler.NoOpSchema;
                    options.DefaultSignInScheme = NoOpAuthHandler.NoOpSchema;
                    options.DefaultSignOutScheme = NoOpAuthHandler.NoOpSchema; 
                    options.DefaultForbidScheme = NoOpAuthHandler.NoOpSchema;
                }
            ).AddScheme<NoOpAuthOptions, NoOpAuthHandler>(NoOpAuthHandler.NoOpSchema, o => { });
        }
    }
}