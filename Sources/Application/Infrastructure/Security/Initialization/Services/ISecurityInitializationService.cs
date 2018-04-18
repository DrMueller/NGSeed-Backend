using Microsoft.Extensions.DependencyInjection;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services
{
    public interface ISecurityInitializationService
    {
        void InitializeSecurity(IServiceCollection services);
    }
}