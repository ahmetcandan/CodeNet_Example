﻿using MediatR;
using CodeNet.Abstraction.Model;
using CodeNet.Identity.Manager;
using CodeNet.Identity.Model;

namespace IdentityApi.Handler
{
    public class UpdateRoleRequestHandler(IIdentityRoleManager IdentityRoleManager) : IRequestHandler<UpdateRoleModel, ResponseBase>
    {
        public async Task<ResponseBase> Handle(UpdateRoleModel request, CancellationToken cancellationToken)
        {
            return await IdentityRoleManager.EditRole(request);
        }
    }
}
