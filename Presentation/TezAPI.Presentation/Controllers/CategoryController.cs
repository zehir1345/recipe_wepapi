using MediatR;
using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.Features.Commands.Category.CreateCategory;
using TezAPI.Application.Features.Queries.Category.GetAllCategory;
using TezAPI.Application.Features.Queries.Category.GetByIdCategory;

namespace TezAPI.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    readonly IMediator _mediator;
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllCategory([FromQuery]GetAllCategoriesQueryRequest request)
    {
        GetAllCategoriesQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetCategory([FromQuery] GetCategoryByIdQueryRequest request)
    {
        GetCategoryByIdQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest request)
    {
        CreateCategoryCommandResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
