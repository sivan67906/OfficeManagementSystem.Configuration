using Configuration.Application.Features.Countries.Commands.CreateCountry;
using Configuration.Application.Features.Countries.Commands.DeleteCountry;
using Configuration.Application.Features.Countries.Commands.UpdateCountry;
using Configuration.Application.Features.Countries.Queries.GetAllCountries;
using Configuration.Application.Features.Countries.Queries.GetCountryById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly IMediator _mediator;
    public CountryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var countryList = await _mediator.Send(new GetAllCountriesQuery());
        return Ok(countryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var country = await _mediator.Send(new GetCountryByIdQuery { Id = Id });
        if (country is not null) { return Ok(country); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCountryCommand command)
    {
        await _mediator.Send(command);
        return Ok("Country Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCountryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteCountryCommand { Id = Id });
        return NoContent();
    }
}