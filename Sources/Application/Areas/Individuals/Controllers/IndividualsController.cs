using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mmu.Ngs.WebApi.Areas.Individuals.Dtos;
using Mmu.Ngs.WebApi.Areas.Individuals.Services;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class IndividualsController : Controller
    {
        private readonly IIndividualService _individualService;

        public IndividualsController(IIndividualService individualService)
        {
            _individualService = individualService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateIndividualAsync([FromBody] IndividualDto dto)
        {
            var result = await _individualService.CreateIndividualAsync(dto);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIndividuals()
        {
            var result = await _individualService.LoadAllIndividualsAsync();
            return Ok(result);
        }
    }
}