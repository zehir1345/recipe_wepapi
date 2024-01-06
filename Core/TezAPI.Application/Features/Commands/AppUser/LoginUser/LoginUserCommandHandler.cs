using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.Abstractions.Services;
using TezAPI.Application.Abstractions.Token;
using TezAPI.Application.DTOs;

namespace TezAPI.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
       
        readonly IAuthService _authseService;

        public LoginUserCommandHandler(IAuthService authseService)
        {
            _authseService = authseService;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _authseService.LoginAsync(request.UsernameOrEmail,request.Password,15);
            return new() 
            { 
                Token = response.Token,
                UserId = response.UserId,
            };
        }
    }
}
