using MediatR;
using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.Features.Commands.Ingredient.CreateAllIngredient;
using TezAPI.Application.Features.Commands.Ingredient.CreateIngredient;
using TezAPI.Application.Features.Commands.Ingredient.RemoveIngredient;
using TezAPI.Application.Features.Commands.Ingredient.UpdateIngredient;
using TezAPI.Application.Features.Queries.Ingredient.GetAllIngredients;
using TezAPI.Application.Features.Queries.Ingredient.GetSearchIngredien;

namespace TezAPI.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IngredientController : ControllerBase
{
    readonly IMediator _mediator;

    public IngredientController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("[action]")]
    public async Task<ActionResult> GetAllIngredient([FromQuery]GetAllIngredientsQueryRequest request)
    {
        GetAllIngredientsQueryResponse response = await _mediator.Send(request);

        return Ok(response);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetSearchIngredient([FromQuery] GetSearchIngredienQueryRequest request) 
    {
        GetSearchIngredienQueryResponse response = await _mediator.Send(request);

        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateIngredient(CreateIngredientCommandRequest request)
    {
        CreateIngredientCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAllIngredient(CreateAllIngredientCommandRequest request)
    {
        CreateAllIngredientCommandResponse response= await _mediator.Send(request);
        return Ok(response);
    }
    [HttpDelete("[action]")]
    public async Task<IActionResult> RemoveIngredient(RemoveIngredientCommandRequest request)
    {
        RemoveIngredientCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateIngredient(UpdateIngredientCommandRequest request)
    {
        UpdateIngredientCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
