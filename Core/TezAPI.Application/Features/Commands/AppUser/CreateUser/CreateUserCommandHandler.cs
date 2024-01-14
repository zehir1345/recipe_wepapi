using MediatR;
using TezAPI.Application.Abstractions.Services;
using TezAPI.Application.DTOs.User;

namespace TezAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;
        public CreateUserCommandHandler(IUserService userService)
        {
           _userService = userService;
        }
        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm,
                NameSurname = request.NameSurname,
                addAllergy = request.addAllergy,
                addFavoriteCategories = request.addFavoriteCategories,
    
            });
            return new()
            {
                Message = response.Message,
                Succeded = response.Succeded,
            };
        }
    }
}
