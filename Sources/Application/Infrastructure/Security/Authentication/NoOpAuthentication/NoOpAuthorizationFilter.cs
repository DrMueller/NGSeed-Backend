using Microsoft.AspNetCore.Mvc.Filters;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authentication.NoOpAuthentication
{
    public class NoOpAuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
        }
    }
}