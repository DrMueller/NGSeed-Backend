using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Ngs.WebApi.Areas.Individuals.Dtos;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Services
{
    public interface IIndividualService
    {
        Task<IndividualDto> CreateIndividualAsync(IndividualDto dto);

        Task<IReadOnlyCollection<IndividualDto>> LoadAllIndividualsAsync();
    }
}