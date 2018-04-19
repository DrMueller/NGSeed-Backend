using Mmu.Ngs.WebApi.Infrastructure.Application.Dtos;

namespace Mmu.Ngs.WebApi.Infrastructure.Application.Services
{
    public interface IApplicationInformationFactory
    {
        ApplicationInformationDto CreateApplicationInformation();
    }
}