using Microsoft.Extensions.DependencyInjection;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authentication.Initialization
{
    public interface IAuthenticationInitializationService
    {
        void Initialize(IServiceCollection services);
    }
}