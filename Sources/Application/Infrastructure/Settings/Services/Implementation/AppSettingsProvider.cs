using Microsoft.Extensions.Options;
using Mmu.Mlh.DataAccess.Areas.DatabaseAccess.Models;
using Mmu.Mlh.DataAccess.Areas.DatabaseAccess.Services;
using Mmu.Ngs.WebApi.Infrastructure.Settings.Models;

namespace Mmu.Ngs.WebApi.Infrastructure.Settings.Services.Implementation
{
    public class AppSettingsProvider : IAppSettingsProvider, IDatabaseSettingsProvider
    {
        private readonly IOptions<AppSettings> _appSettingsOptions;

        public AppSettingsProvider(IOptions<AppSettings> appSettingsOptions)
        {
            _appSettingsOptions = appSettingsOptions;
        }

        public AppSettings ProvideAppSettings() => _appSettingsOptions.Value;

        public DatabaseSettings ProvideSettings() => _appSettingsOptions.Value.DatabaseSettings;
    }
}