using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Application.AppServices
{
    public interface IIndividualAppService
    {
        Task<IndividualDto> CreateIndividualAsync(IndividualDto dto);

        Task<IReadOnlyCollection<IndividualDto>> LoadAllIndividualsAsync();
    }
}