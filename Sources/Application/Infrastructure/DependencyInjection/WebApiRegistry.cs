using StructureMap;

namespace Mmu.Ngs.WebApi.Infrastructure.DependencyInjection
{
    public class WebApiRegistry : Registry
    {
        public WebApiRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssemblyContainingType<WebApiRegistry>();
                    scanner.WithDefaultConventions();
                });
        }
    }
}