using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Features.Commands.AppUser.UpdateUsername
{
    public class UpdateUsernameCommadRequest : IRequest<UpdateUsernameCommadResponse>
    {
        public string currentEmail { get; set; }
        public string newEmail { get; set; }
    }
}
