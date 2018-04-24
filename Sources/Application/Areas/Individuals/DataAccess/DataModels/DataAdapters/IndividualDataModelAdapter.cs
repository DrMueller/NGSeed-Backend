using AutoMapper;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Factories;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.DataAccess.DataModels.DataAdapters
{
    public class IndividualDataModelAdapter : IDataModelAdapter<IndividualDataModel, Individual>
    {
        private readonly IIndividualFactory _individualFactory;
        private readonly IMapper _mapper;

        public IndividualDataModelAdapter(IIndividualFactory individualFactory, IMapper mapper)
        {
            _individualFactory = individualFactory;
            _mapper = mapper;
        }

        public Individual Adapt(IndividualDataModel dataModel) => _individualFactory.CreateIndividual(
            dataModel.FirstName,
            dataModel.LastName,
            dataModel.Gender,
            dataModel.BirthDate,
            dataModel.Id);

        public IndividualDataModel Adapt(Individual aggregateRoot) => _mapper.Map<IndividualDataModel>(aggregateRoot);
    }
}