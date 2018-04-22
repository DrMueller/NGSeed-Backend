using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Mmu.Ngs.WebApi.Infrastructure.Security.Authorization.PolicyConfiguration;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authorization.Initialization.Implementation
{
    public class AuthorizationInitializationService : IAuthorizationInitializationService
    {
        private readonly IPolicyProviderResolver _policyProviderResolver;

        public AuthorizationInitializationService(IPolicyProviderResolver policyProviderResolver)
        {
            _policyProviderResolver = policyProviderResolver;
        }

        public async Task InitializeAsync(IServiceCollection services)
        {
            Task task = null;
            services.AddAuthorization(
                options =>
                {
                    task = _policyProviderResolver.ConfigurePoliciesAsync(options);
                });

            await task;
        }
    }
}