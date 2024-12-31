using Configuration.Application.Features.BusinessCategories.Commands.CreateBusinessCategory;
using Configuration.Application.Features.BusinessCategories.Commands.DeleteBusinessCategory;
using Configuration.Application.Features.BusinessCategories.Commands.UpdateBusinessCategory;
using Configuration.Application.Features.BusinessCategories.Queries.GetAllBusinessCategories;
using Configuration.Application.Features.BusinessCategories.Queries.GetBusinessCategoryById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Settings.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusinessCategoryController : ControllerBase
{
    private readonly IMediator _mediator;
    public BusinessCategoryController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var businessCategoryList = await _mediator.Send(new GetAllBusinessCategoriesQuery());
        return Ok(businessCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var businessCategory = await _mediator.Send(new GetBusinessCategoryByIdQuery { Id = Id });
        if (businessCategory is not null) { return Ok(businessCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBusinessCategoryCommand command)
    {
        await _mediator.Send(command);
        return Ok("BusinessCategory Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBusinessCategoryCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteBusinessCategoryCommand { Id = Id });
        return NoContent();
    }
}












































