using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Microsoft.Graph;

namespace Mmu.Ngs.WebApi.Areas.AzureAd.AppServices.Implementation
{
    public class GraphAppService : IGraphAppService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GraphAppService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task TestAsync()
        {
            ////try
            ////{
            ////    StringValues authToken;
            ////    _httpContextAccessor.HttpContext.Request.Headers.TryGetValue("Authorization", out authToken);

            ////    var str = authToken.Single();

            ////    var graphClient = new GraphServiceClient(
            ////        new DelegateAuthenticationProvider(
            ////            async requestMessage =>
            ////            {
            ////                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", str);
            ////            }));

            ////    var tra = graphClient.Users.Request();
            ////    var result = await tra.GetAsync();
            ////}
            ////catch (Exception ex)
            ////{
            ////}
        }
    }
}