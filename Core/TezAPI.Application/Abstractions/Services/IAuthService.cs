using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.Abstractions.Services
{
    public interface IAuthService
    {
        Task<DTOs.User.LoginUserResponse>LoginAsync(string usernameOrEmail, string password, int accessTokenTime);
        Task<DTOs.User.LogoutUserResponse> Logout();
    }
}

