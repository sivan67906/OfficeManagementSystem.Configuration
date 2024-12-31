using MediatR;
using Microsoft.AspNetCore.Mvc;
using Settings.Application.Features.PlanTypes.Commands.CreatePlanType;
using Settings.Application.Features.PlanTypes.Commands.DeletePlanType;
using Settings.Application.Features.PlanTypes.Commands.UpdatePlanType;
using Settings.Application.Features.PlanTypes.Queries.GetAllPlanTypes;
using Settings.Application.Features.PlanTypes.Queries.GetPlanTypeById;

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

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var planType = await _mediator.Send(new GetPlanTypeByIdQuery { Id = Id });
        if (planType is not null) { return Ok(planType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePlanTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("PlanType Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePlanTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeletePlanTypeCommand { Id = Id });
        return NoContent();
    }
}






