using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.DTOs.User.UpdateEmail;
using TezAPI.Application.Features.Commands.AppUser.CreateUser;
using TezAPI.Application.Features.Commands.AppUser.LoginUser;
using TezAPI.Application.Features.Commands.AppUser.LogoutUser;
using TezAPI.Application.Features.Commands.AppUser.UpdaeEmail;
using TezAPI.Application.Features.Commands.AppUser.UpdatePassword;
using TezAPI.Application.Features.Commands.AppUser.UpdateUsername;
using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    readonly IMediator _mediator;
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateUser(CreateUserCommandRequest request)
    {
        CreateUserCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }


    [HttpPost("[action]")]
    public async Task<IActionResult> Login(LoginUserCommandRequest request)
    {
        LoginUserCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> Logout(LogoutUserCommandRequest request)
    {  
        LogoutUserCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateEmail(UpdateEmailCommandRequest request)
    {
        UpdateEmailCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> UpdatePassword(UpdatePasswordCommandRequest request)
    {
        UpdatePasswordCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> UpdateUserName(UpdateUsernameCommadRequest request)
    {
       UpdateUsernameCommadResponse response = await _mediator.Send(request);
        return Ok(response);
    }

}



