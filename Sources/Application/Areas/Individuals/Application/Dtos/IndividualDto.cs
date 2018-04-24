using System;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos
{
    public class IndividualDto
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public GenderDto Gender { get; set; }
        public string Id { get; set; }
        public string LastName { get; set; }
    }
}