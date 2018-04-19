using Microsoft.Extensions.DependencyInjection;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Initialization.Services
{
    public interface ISecurityServiceInitializationService
    {
        void InitializeSecurity(IServiceCollection services);
    }
}