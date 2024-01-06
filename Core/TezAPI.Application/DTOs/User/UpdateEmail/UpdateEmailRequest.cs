using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs.User.UpdateEmail
{
    public class UpdateEmailRequest
    {
        public string UserId { get; set; }
        public string newEmail { get; set; }
    }
}
