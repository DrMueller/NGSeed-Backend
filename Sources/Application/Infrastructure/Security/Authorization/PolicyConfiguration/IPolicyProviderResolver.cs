using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authorization.PolicyConfiguration
{
    public interface IPolicyProviderResolver
    {
        Task ConfigurePoliciesAsync(AuthorizationOptions options);
    }
}