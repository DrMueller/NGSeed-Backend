using Microsoft.Extensions.Options;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Models;

namespace Mmu.Ngs.WebApi.Infrastructure.Settings.Services.Implementation
{
    public class AppSettingsProvider : IAppSettingsProvider
    {
        private readonly IOptions<AppSettings> _appSettingsOptions;

        public AppSettingsProvider(IOptions<AppSettings> appSettingsOptions)
        {
            _appSettingsOptions = appSettingsOptions;
        }

        public AppSettings GetAppSettings() => _appSettingsOptions.Value;
    }
}