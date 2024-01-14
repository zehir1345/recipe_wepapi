using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs.User
{
    public class LoginUserResponse
    {
        public  Guid UserId { get; set; }
        public Token Token{ get; set; }
    }
}
