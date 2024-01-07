using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Services;

namespace TezAPI.Application.Features.Commands.AppUser.UpdateUsername
{
    public class UpdateUsernameCommadHandler : IRequestHandler<UpdateUsernameCommadRequest, UpdateUsernameCommadResponse>
    {
        readonly IUserService _userService;

        public UpdateUsernameCommadHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdateUsernameCommadResponse> Handle(UpdateUsernameCommadRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.UpdateUsernameAsync(request.currentEmail,request.newEmail);
            return new()
            {
               Message = response.Message,
               Succeded = response.Succeded,
            };
        }
    }
}
