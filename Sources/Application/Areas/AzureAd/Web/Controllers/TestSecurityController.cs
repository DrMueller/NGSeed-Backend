using System.Linq;
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
        public IActionResult TestGivenName()
        {
            return Ok(new { Result = "OK" });
        }

        [HttpGet("TestNameMatthiasMueller")]
        [Authorize("NameMatthiasMuellerPolicy")]
        public IActionResult TestNameMatthiasMueller()
        {
            return Ok(new { Result = "OK" });
        }

        [HttpGet("TestNeverFullFilled")]
        [Authorize("NeverFullfilledPolicy")]
        public IActionResult TestNeverFullFilled()
        {
            return Ok(new { Result = "OK" });
        }
    }
}