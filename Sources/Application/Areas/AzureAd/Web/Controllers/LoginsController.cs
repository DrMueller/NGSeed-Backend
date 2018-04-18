using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mmu.Ngs.WebApi.Areas.AzureAd.Web.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class LoginsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            const string TenantId = "novacapta.de";
            const string ThisClientId = "f9aa233a-c9fe-493e-b5d9-0ea2cca7b22f";
            const string RequestedResourceUrl = "https://novacapta.de/122ae2f0-5e99-4171-93d8-c58048e8f44f";
            const string ClientSecret = "YgB6VYzY720rYL7iRUQVhmLyY1ii1nk2TEvSJj4ES4A=";
            const string UserName = "m.mueller@novacapta.com";
            const string UserPassword = "Joker1joker1";
            const string Instance = "https://login.microsoftonline.com/";
            var authority = $"{Instance}{TenantId}";

            var client = new HttpClient();
            var body = $"resource={RequestedResourceUrl}&client_id={ThisClientId}&grant_type=password&username={UserName}&password={UserPassword}&scope=openid&client_secret={ClientSecret}";

            var stringContent = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");

            var endpointUri = new Uri($"{authority}/oauth2/token");
            var response = await client.PostAsync(endpointUri, stringContent);
            var responseString = await response.Content.ReadAsStringAsync();

            return Ok(responseString);
        }
    }
}