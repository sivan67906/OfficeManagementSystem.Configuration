using Configuration.Application.Features.BusinessTypes.Commands.CreateBusinessType;
using Configuration.Application.Features.BusinessTypes.Commands.DeleteBusinessType;
using Configuration.Application.Features.BusinessTypes.Commands.UpdateBusinessType;
using Configuration.Application.Features.BusinessTypes.Queries.GetAllBusinessTypes;
using Configuration.Application.Features.BusinessTypes.Queries.GetBusinessTypeById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusinessTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public BusinessTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var businessTypeList = await _mediator.Send(new GetAllBusinessTypesQuery());
        return Ok(businessTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var businessType = await _mediator.Send(new GetBusinessTypeByIdQuery { Id = Id });
        if (businessType is not null) { return Ok(businessType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBusinessTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("BusinessType Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBusinessTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteBusinessTypeCommand { Id = Id });
        return NoContent();
    }
}


