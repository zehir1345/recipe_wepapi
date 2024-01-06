using MediatR;
using Microsoft.AspNetCore.Mvc;
using TezAPI.Application.Features.Queries.Allergy.GetAllAllergy;
using TezAPI.Application.Features.Queries.Allergy.GetByIdAllergy;

namespace TezAPI.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AllergyController : ControllerBase
{
    readonly IMediator _mediator;

    public AllergyController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllAllergy([FromQuery] GetAllAllergyQueryRequesst requesst)
    {
        GetAllAllergyQueryResponse response = await _mediator.Send(requesst);
        return Ok(response);
    }
    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAllergyAsync(GetByIdAllergyQueryrequest request)
    {
        GetByIdAllergyQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}
