using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Services;

namespace TezAPI.Application.Features.Commands.AppUser.LogoutUser
{
    public class LogoutUserCommandHandler : IRequestHandler<LogoutUserCommandRequest, LogoutUserCommandResponse>
    {
        readonly IAuthService _authseService;

        public LogoutUserCommandHandler(IAuthService authseService)
        {
            _authseService = authseService;
        }

        public async Task<LogoutUserCommandResponse> Handle(LogoutUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _authseService.Logout();
            return new()
            {
               Succeded = response.Succeded,
               Message = response.Message,
            };
        }
    }
}
