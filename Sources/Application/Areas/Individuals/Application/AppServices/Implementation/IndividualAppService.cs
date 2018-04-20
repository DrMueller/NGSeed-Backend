using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Factories;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Repositories;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Application.AppServices.Implementation
{
    public class IndividualAppService : IIndividualAppService
    {
        private readonly IIndividualFactory _individualFactory;
        private readonly IIndividualRepository _individualRepository;
        private readonly IMapper _mapper;

        public IndividualAppService(
            IIndividualRepository individualRepository,
            IIndividualFactory individualFactory,
            IMapper mapper)
        {
            _individualRepository = individualRepository;
            _individualFactory = individualFactory;
            _mapper = mapper;
        }

        public async Task<IndividualDto> CreateIndividualAsync(IndividualDto dto)
        {
            var gender = dto.Gender == GenderDto.Female ? Gender.Female : Gender.Male;

            var individual = _individualFactory.CreateIndividual(
                dto.FirstName,
                dto.LastName,
                gender,
                dto.BirthDate);

            var returnedIndividual = await _individualRepository.SaveAsync(individual);

            var result = _mapper.Map<IndividualDto>(returnedIndividual);
            return result;
        }

        public async Task<IReadOnlyCollection<IndividualDto>> LoadAllIndividualsAsync()
        {
            var allIndividuals = await _individualRepository.LoadAllAsync();
            var result = _mapper.Map<List<IndividualDto>>(allIndividuals);
            return result;
        }
    }
}