using Mmu.Ngs.WebApi.Infrastructure.Application.Dtos;

namespace Mmu.Ngs.WebApi.Infrastructure.Application.Services.Implementation
{
    public class ApplicationInformationFactory : IApplicationInformationFactory
    {
        public ApplicationInformationDto CreateApplicationInformation()
        {
            var applicationVersion = typeof(ApplicationInformationFactory).Assembly.GetName().Version.ToString();
            var result = new ApplicationInformationDto
            {
                ApplicationVersion = applicationVersion,
                ApplicationTitle = "NG-Seed"
            };

            return result;
        }
    }
}