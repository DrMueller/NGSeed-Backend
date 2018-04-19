using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmu.Ngs.WebApi.Infrastructure.Application.Services;

namespace Mmu.Ngs.WebApi.Infrastructure.Application.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ApplicationInformationsController : Controller
    {
        private readonly IApplicationInformationFactory _applicationInformationFactory;

        public ApplicationInformationsController(
            IApplicationInformationFactory applicationInformationFactory)
        {
            _applicationInformationFactory = applicationInformationFactory;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetApplicationInformation()
        {
            var dto = _applicationInformationFactory.CreateApplicationInformation();
            return Ok(dto);
        }
    }
}