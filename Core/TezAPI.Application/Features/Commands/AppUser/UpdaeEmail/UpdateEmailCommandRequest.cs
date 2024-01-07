using MediatR;

namespace TezAPI.Application.Features.Commands.AppUser.UpdaeEmail
{
    public class UpdateEmailCommandRequest : IRequest<UpdateEmailCommandResponse>
    {
        public string currentEmail { get; set; }
        public string newEmail { get; set; }
    }
}
