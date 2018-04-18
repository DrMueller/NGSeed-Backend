using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mmu.Ngs.WebApi.Areas.Individuals.Dtos;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Services.Implementation
{
    public class IndividualService : IIndividualService
    {
        public Task<IndividualDto> CreateIndividualAsync(IndividualDto dto)
        {
            dto.Id = "123";
            return Task.FromResult(dto);
        }

        public Task<IReadOnlyCollection<IndividualDto>> LoadAllIndividualsAsync()
        {
            var individuals = new List<IndividualDto>
            {
                new IndividualDto
                {
                    BirthDate = new DateTime(2000, 1, 1),
                    FirstName = "Hans",
                    Gender = IndividualGenderDto.Male,
                    Id = "321",
                    LastName = "Reber"
                },
                new IndividualDto
                {
                    BirthDate = new DateTime(1990, 1, 1),
                    FirstName = "Stefanie",
                    Gender = IndividualGenderDto.Female,
                    Id = "3535",
                    LastName = "Suter"
                }
            };

            var result = (IReadOnlyCollection<IndividualDto>)individuals;
            return Task.FromResult(result);
        }
    }
}