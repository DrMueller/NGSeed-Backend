using System;
using Mmu.Mlh.DataAccess.Areas.IdGeneration;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Domain.Factories.Implementation
{
    public class IndividualFactory : IIndividualFactory
    {
        private readonly IEntityIdFactory _entityIdFactory;

        public IndividualFactory(IEntityIdFactory entityIdFactory)
        {
            _entityIdFactory = entityIdFactory;
        }

        public Individual CreateIndividual(string firstName, string lastName, Gender gender, DateTime birthDate, string id = null)
        {
            var entityId = id ?? _entityIdFactory.CreateEntityId();
            return new Individual(entityId, firstName, lastName, gender, birthDate);
        }
    }
}