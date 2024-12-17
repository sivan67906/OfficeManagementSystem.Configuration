using Configuration.Application.Features.PlanTypes.Queries.GetAllPlanTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlanTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public PlanTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var planTypeList = await _mediator.Send(new GetAllPlanTypesQuery());
        return Ok(planTypeList);
    }
}