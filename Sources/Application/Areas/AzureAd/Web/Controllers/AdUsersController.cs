using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Mmu.Ngs.WebApi.Areas.AzureAd.AppServices;

namespace Mmu.Ngs.WebApi.Areas.AzureAd.Web.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class AdUsersController : Controller
    {
        private readonly IGraphAppService _graphAppService;

        public AdUsersController(IGraphAppService graphAppService)
        {
            _graphAppService = graphAppService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _graphAppService.TestAsync();
            return Ok();
        }
    }
}
