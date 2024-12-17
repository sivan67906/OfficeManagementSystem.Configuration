using Configuration.Application.Features.Companies.Commands.CreateCompany;
using Configuration.Application.Features.Companies.Commands.DeleteCompany;
using Configuration.Application.Features.Companies.Commands.UpdateCompany;
using Configuration.Application.Features.Companies.Queries.GetAllCompanies;
using Configuration.Application.Features.Companies.Queries.GetCompanyById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly IMediator _mediator;
    public CompanyController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var companyList = await _mediator.Send(new GetAllCompaniesQuery());
        return Ok(companyList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var company = await _mediator.Send(new GetCompanyByIdQuery { Id = Id });
        if (company is not null) { return Ok(company); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCompanyCommand command)
    {
        await _mediator.Send(command);
        return Ok("Company Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCompanyCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteCompanyCommand { Id = Id });
        return NoContent();
    }
}