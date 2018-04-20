using AutoMapper;
using Mmu.Ngs.WebApi.Areas.Individuals.Domain.Models;

namespace Mmu.Ngs.WebApi.Areas.Individuals.Application.Dtos.Profiles
{
    public class GenderDtoProfile : Profile
    {
        public GenderDtoProfile()
        {
            CreateMap<Gender, GenderDto>().ConvertUsing(
                value =>
                {
                    switch (value)
                    {
                        case Gender.Female:
                            return GenderDto.Female;
                        default:
                            return GenderDto.Male;
                    }
                });
        }
    }
}