using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.NoOpAuthentication
{
    public class NoOpAuthHandler : AuthenticationHandler<NoOpAuthOptions>
    {
        public const string NoOpSchema = "NoOp";

        public NoOpAuthHandler(IOptionsMonitor<NoOpAuthOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync() => Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(Context.User, NoOpSchema)));
    }
}