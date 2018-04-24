using System;
using Mmu.Mlh.DataAccess.Areas.DataModeling.Models;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.DataAccess.DataModels
{
    public class IndividualDataModel : DataModelBase
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }
    }
}