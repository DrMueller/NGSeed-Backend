using System;
using Mmu.Mlh.DomainExtensions.Areas.DomainModeling;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models
{
    public class Individual : AggregateRoot
    {
        public Individual(
            string id,
            string firstName,
            string lastName,
            Gender gender,
            DateTime birthDate) : base(id)
        {
            Guard.StringNotNullOrEmpty(() => firstName);
            Guard.StringNotNullOrEmpty(() => lastName);

            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthDate = birthDate;
        }

        public DateTime BirthDate { get; }
        public string FirstName { get; }
        public Gender Gender { get; }
        public string LastName { get; }
    }
}