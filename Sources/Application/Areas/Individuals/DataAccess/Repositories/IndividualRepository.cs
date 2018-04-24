using Mmu.Mlh.DataAccess.Areas.DatabaseAccess.Services;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Services;
using Mmu.Mlh.DataAccess.Areas.Repositories;
using Mmu.Ngs.WebApi.Areas.Individuals.DataAccess.DataModels;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Repositories;

namespace Mmu.Ngs.WebApi.Areas.Individuals.DataAccess.Repositories
{
    public class IndividualRepository : RepositoryBase<Individual, IndividualDataModel>, IIndividualRepository
    {
        public IndividualRepository(IDataModelRepository<IndividualDataModel> dataModelRepository, IDataModelAdapter<IndividualDataModel, Individual> dataModelAdapter) : base(dataModelRepository, dataModelAdapter)
        {
        }
    }
}