using MediatR;

namespace TezAPI.Application.Features.Commands.AppUser.UpdaeEmail
{
    public class UpdateEmailCommandRequest : IRequest<UpdateEmailCommandResponse>
    {
        public DTOs.User.UpdateEmail.UpdateEmailRequest Request { get; set; }
    }
}
