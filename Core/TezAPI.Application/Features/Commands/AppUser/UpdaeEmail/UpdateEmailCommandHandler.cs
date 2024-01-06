using MediatR;
using TezAPI.Application.Abstractions.Services;

namespace TezAPI.Application.Features.Commands.AppUser.UpdaeEmail
{
    public class UpdateEmailCommandHandler : IRequestHandler<UpdateEmailCommandRequest, UpdateEmailCommandResponse>
    {
        readonly IUserService _userService;

        public UpdateEmailCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdateEmailCommandResponse> Handle(UpdateEmailCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _userService.UpdateEmailAsync(request.Request);
            return new()
            {
                UpdateEmailResponse = response,
            };
        }
    }
}
