using Configuration.Application.Features.SearchConsumers.Commands.CreateSearchConsumer;
using Configuration.Application.Features.SearchConsumers.Commands.DeleteSearchConsumer;
using Configuration.Application.Features.SearchConsumers.Commands.UpdateSearchConsumer;
using Configuration.Application.Features.SearchConsumers.Queries.GetAllSearchConsumers;
using Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumerByDateBetween;
using Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumerById;
using Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByDate;
using Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByName;
using Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByPhone;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SearchConsumerController : ControllerBase
{
    private readonly IMediator _mediator;
    public SearchConsumerController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllSearchConsumersQuery());
        return Ok(consumerList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var consumer = await _mediator.Send(new GetSearchConsumerByIdQuery { Id = Id });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    //[HttpGet("{consumerName:required}")]
    //public async Task<IActionResult> GetByConsumerName(string consumerName)
    //{
    //    var consumer = await _mediator.Send(new GetConsumerByNameQuery { ConsumerName = consumerName });
    //    if (consumer is not null) { return Ok(consumer); }
    //    return NotFound();
    //}

    [HttpGet("{consumerName}")]
    public async Task<IActionResult> GetSearchByConsumerName(string consumerName)
    {
        var consumer = await _mediator.Send(new GetSearchConsumersByNameQuery { ConsumerName = consumerName });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{consumerPhoneNumber}")]
    public async Task<IActionResult> GetSearchByPhoneNumber(string consumerPhoneNumber)
    {
        var consumer = await _mediator.Send(new GetSearchConsumersByPhoneQuery { PhoneNumber = consumerPhoneNumber });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{searchDate}")]
    public async Task<IActionResult> GetSearchByPhoneNumber(DateTime searchDate)
    {
        var consumer = await _mediator.Send(new GetSearchConsumersByDateQuery { SearchDate = searchDate });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{startDate}/{endDate}")]
    public async Task<IActionResult> GetSearchByDateBetween(DateTime startDate, DateTime endDate)
    {
        var consumer = await _mediator.Send(new GetSearchConsumerByDateBetweenQuery { StartDate = startDate, EndDate = endDate });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateSearchConsumerCommand command)
    {
        await _mediator.Send(command);
        return Ok("Consumer Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateSearchConsumerCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteSearchConsumerCommand { Id = Id });
        return NoContent();
    }
}