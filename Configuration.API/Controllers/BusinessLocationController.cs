using Configuration.Application.Features.BusinessLocations.Commands.CreateBusinessLocation;
using Configuration.Application.Features.BusinessLocations.Commands.DeleteBusinessLocation;
using Configuration.Application.Features.BusinessLocations.Commands.UpdateBusinessLocation;
using Configuration.Application.Features.BusinessLocations.Queries.GetAllBusinessLocations;
using Configuration.Application.Features.BusinessLocations.Queries.GetBusinessLocationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusinessLocationController : ControllerBase
{
    private readonly IMediator _mediator;
    public BusinessLocationController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var businessLocationList = await _mediator.Send(new GetAllBusinessLocationsQuery());
        return Ok(businessLocationList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var businessLocation = await _mediator.Send(new GetBusinessLocationByIdQuery { Id = Id });
        if (businessLocation is not null) { return Ok(businessLocation); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBusinessLocationCommand command)
    {
        await _mediator.Send(command);
        return Ok("BusinessLocation Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBusinessLocationCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteBusinessLocationCommand { Id = Id });
        return NoContent();
    }
}