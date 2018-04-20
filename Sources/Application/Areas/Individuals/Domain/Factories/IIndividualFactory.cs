using System;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Domain.Factories
{
    public interface IIndividualFactory
    {
        Individual CreateIndividual(
            string firstName,
            string lastName,
            Gender gender,
            DateTime birthDate,
            string id = null);
    }
}