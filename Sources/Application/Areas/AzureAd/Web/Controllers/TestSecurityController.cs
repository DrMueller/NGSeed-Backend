using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mmu.Ngs.WebApi.Areas.AzureAd.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class TestSecurityController : Controller
    {
        [HttpGet("TestGivenName")]
        [Authorize("GivenNamePolicy")]
        public IActionResult TestGivenName() => Ok(new { Result = "OK" });

        [HttpGet("TestNameMatthiasMueller")]
        [Authorize("NameMatthiasMuellerPolicy")]
        public IActionResult TestNameMatthiasMueller() => Ok(new { Result = "OK" });

        [HttpGet("TestNeverFullFilled")]
        [Authorize("NeverFullfilledPolicy")]
        public IActionResult TestNeverFullFilled() => Ok(new { Result = "OK" });
    }
}