using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.AppUser.LogoutUser
{
    public class LogoutUserCommandResponse
    {
        public bool Succeded { get; set; }
        public string Message { get; set; }
    }
}
