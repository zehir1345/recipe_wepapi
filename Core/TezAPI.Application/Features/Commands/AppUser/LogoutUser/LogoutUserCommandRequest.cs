using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.AppUser.LogoutUser
{
    public class LogoutUserCommandRequest : IRequest<LogoutUserCommandResponse>
    {
    }
}
