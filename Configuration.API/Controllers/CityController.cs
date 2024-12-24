using Configuration.Application.Features.Cities.Commands.CreateCity;
using Configuration.Application.Features.Cities.Commands.DeleteCity;
using Configuration.Application.Features.Cities.Commands.UpdateCity;
using Configuration.Application.Features.Cities.Queries.GetAllCities;
using Configuration.Application.Features.Cities.Queries.GetCitiesByParentId;
using Configuration.Application.Features.Cities.Queries.GetCityById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly IMediator _mediator;
    public CityController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var cityList = await _mediator.Send(new GetAllCitiesQuery());
        return Ok(cityList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var city = await _mediator.Send(new GetCityByIdQuery { Id = Id });
        if (city is not null) { return Ok(city); }
        return NotFound();
    }
    [HttpGet("GetByParentId")]
    public async Task<IActionResult> GetByParentId(int parentId)
    {
        var state = await _mediator.Send(new GetCitiesByParentIdQuery { StateId = parentId });
        if (state is not null) { return Ok(state); }
        return NotFound();
    }
    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCityCommand command)
    {
        await _mediator.Send(command);
        return Ok("City Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCityCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteCityCommand { Id = Id });
        return NoContent();
    }
}