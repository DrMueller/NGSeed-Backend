using Mmu.Ngs.WebApi.Infrastructure.Settings.Models;

namespace Mmu.Ngs.WebApi.Infrastructure.Settings.Services
{
    public interface IAppSettingsProvider
    {
        AppSettings ProvideAppSettings();
    }
}