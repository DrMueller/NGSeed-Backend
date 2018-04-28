using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmu.Ngs.WebApi.Areas.Individuals.Application.AppServices;
using Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class IndividualsController : Controller
    {
        private readonly IIndividualAppService _individualService;

        public IndividualsController(IIndividualAppService individualService)
        {
            _individualService = individualService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndividualAsync([FromBody] IndividualDto dto)
        {
            var result = await _individualService.CreateIndividualAsync(dto);
            return Ok(result);
        }

        [HttpGet("Error")]
        public virtual IActionResult ForceException() => throw new ArgumentException("Hello from the Individueals Controller!");

        [HttpGet]
        public async Task<IActionResult> GetAllIndividuals()
        {
            var result = await _individualService.LoadAllIndividualsAsync();
            return Ok(result);
        }

        [AllowAnonymous]
        [HttpGet("HelloWorld")]
        public virtual IActionResult GetHelloWorld() => Ok("Hello World");
    }
}