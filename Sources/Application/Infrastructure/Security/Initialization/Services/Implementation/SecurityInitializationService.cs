using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Services;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services.Implementation
{
    public class SecurityInitializationService : ISecurityInitializationService
    {
        private readonly IAppSettingsProvider _appSettingsProvider;

        public SecurityInitializationService(IAppSettingsProvider appSettingsProvider)
        {
            _appSettingsProvider = appSettingsProvider;
        }

        public void InitializeSecurity(IServiceCollection services)
        {
            var azureAdSettings = _appSettingsProvider.GetAppSettings().AzureAdSettings;
            services.AddAuthentication(
                options =>
                {
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                }
            ).AddJwtBearer(
                options =>
                {
                    options.IncludeErrorDetails = true;
                    options.Authority = $"{azureAdSettings.Instance}{azureAdSettings.TenantId}";
                    options.Audience = azureAdSettings.AudienceId;
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                });
        }
    }
}