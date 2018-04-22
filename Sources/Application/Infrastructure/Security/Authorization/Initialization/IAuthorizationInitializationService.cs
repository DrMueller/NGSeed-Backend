using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authorization.Initialization
{
    public interface IAuthorizationInitializationService
    {
        Task InitializeAsync(IServiceCollection services);
    }
}