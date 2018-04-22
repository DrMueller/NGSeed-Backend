﻿using System.Collections.Generic;
using System.Security.Claims;

namespace Mmu.Ngs.WebApi.Infrastructure.Security.Authorization.ClaimProvisioning
{
    public interface IClaimProvider
    {
        IReadOnlyCollection<Claim> ProvideClaims(string userId);
    }
}