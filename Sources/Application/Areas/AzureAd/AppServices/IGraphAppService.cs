using System.Threading.Tasks;

namespace Mmu.Ngs.WebApi.Areas.AzureAd.AppServices
{
    public interface IGraphAppService
    {
        Task TestAsync();
    }
}