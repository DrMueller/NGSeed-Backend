using System;
using System.Linq.Expressions;
using AutoMapper;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos.Profiles
{
    public class IndividualDtoProfile : Profile
    {
        public IndividualDtoProfile()
        {
            CreateMap<Individual, IndividualDto>()
                .ForMember(d => d.BirthDate, c => c.MapFrom(f => f.BirthDate))
                .ForMember(d => d.FirstName, c => c.MapFrom(f => f.FirstName))
                .ForMember(d => d.Gender, c => c.MapFrom(f => f.Gender))
                .ForMember(d => d.Id, c => c.MapFrom(f => f.Id))
                .ForMember(d => d.LastName, c => c.MapFrom(f => f.LastName));
        }
    }
}