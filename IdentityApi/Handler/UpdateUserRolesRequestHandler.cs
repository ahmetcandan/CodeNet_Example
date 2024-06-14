﻿using MediatR;
using CodeNet.Abstraction.Model;
using CodeNet.Identity.Manager;
using CodeNet.Identity.Model;

namespace IdentityApi.Handler
{
    public class UpdateUserRolesRequestHandler(IIdentityUserManager IdentityUserManager) : IRequestHandler<UpdateUserRolesModel, ResponseBase>
    {
        public async Task<ResponseBase> Handle(UpdateUserRolesModel request, CancellationToken cancellationToken)
        {
            return await IdentityUserManager.EditUserRoles(request);
        }
    }
}
