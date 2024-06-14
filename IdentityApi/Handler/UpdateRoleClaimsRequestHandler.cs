﻿using MediatR;
using CodeNet.Abstraction.Model;
using CodeNet.Identity.Manager;
using CodeNet.Identity.Model;

namespace IdentityApi.Handler
{
    public class UpdateRoleClaimsRequestHandler(IIdentityRoleManager IdentityRoleManager) : IRequestHandler<RoleClaimsModel, ResponseBase>
    {
        public async Task<ResponseBase> Handle(RoleClaimsModel request, CancellationToken cancellationToken)
        {
            return await IdentityRoleManager.EditRoleClaims(request);
        }
    }
}
