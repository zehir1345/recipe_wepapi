using Microsoft.AspNetCore.Identity;
using TezAPI.Application.Abstractions.Services;
using TezAPI.Application.Abstractions.Token;
using TezAPI.Application.DTOs;
using TezAPI.Application.DTOs.User;
using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Persistence.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<TezAPI.Domain.Entities.Identity.AppUser> _userManager;
        readonly SignInManager<TezAPI.Domain.Entities.Identity.AppUser> _signInManager;
        readonly ITokenHandler _tokenHandler;
        
        public AuthService(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, 
            ITokenHandler tokenHandler
             )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
            
        }

        public async Task<LoginUserResponse> LoginAsync(string usernameOrEmail, string password,int accessTokenTime)
        {
             var u = await _userManager.FindByNameAsync(usernameOrEmail);
            if (u == null)
                u = await _userManager.FindByEmailAsync(usernameOrEmail);
            if (u == null)
                throw new Exception("Kullanıcı veya  şifre hatalı");
            SignInResult result = await _signInManager.CheckPasswordSignInAsync(u, password, false);

            if (result.Succeeded)//Authentication başarılı
            {
                Guid id = u.UserId;
                Token token = _tokenHandler.CreateAccessToken(accessTokenTime);
                return new()
                {  
                    Token = token,
                    UserId = id,
                };
            }
            return new() { };
        }

        public async Task<LogoutUserResponse> Logout()
        {
            await _signInManager.SignOutAsync(); // Kullanıcıyı oturumdan çıkar

            return new()
            {
                Succeded = true,
                Message = "Logout successful"
            };
        }
    }
}
