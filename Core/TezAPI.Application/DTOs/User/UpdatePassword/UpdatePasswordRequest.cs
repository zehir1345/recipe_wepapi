using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs.User.UpdatePassword
{
    public class UpdatePasswordRequest
    {
        public string UserId { get; set; }
        public string newPassword { get; set; }
        public string newPasswordConfirm { get; set; }
    }
}
