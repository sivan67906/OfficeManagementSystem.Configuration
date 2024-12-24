using Configuration.Application.Features.Consumers.Commands.CreateConsumer;
using Configuration.Application.Features.Consumers.Commands.DeleteConsumer;
using Configuration.Application.Features.Consumers.Commands.UpdateConsumer;
using Configuration.Application.Features.Consumers.Queries.GetAllConsumers;
using Configuration.Application.Features.Consumers.Queries.GetConsumerByDateBetween;
using Configuration.Application.Features.Consumers.Queries.GetConsumerById;
using Configuration.Application.Features.Consumers.Queries.GetConsumerByName;
using Configuration.Application.Features.Consumers.Queries.GetConsumersByDate;
using Configuration.Application.Features.Consumers.Queries.GetConsumersByPhone;
using Configuration.Application.Features.Consumers.Queries.GetConsumersBySearch;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConsumerController : ControllerBase
{
    private readonly IMediator _mediator;
    public ConsumerController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllConsumersQuery());
        return Ok(consumerList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(int Id)
    {
        var consumer = await _mediator.Send(new GetCompanyByIdQuery { Id = Id });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{consumerName:required}")]
    public async Task<IActionResult> GetByConsumerName(string consumerName)
    {
        var consumer = await _mediator.Send(new GetConsumerByNameQuery { ConsumerName = consumerName });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("search")]
    public async Task<IActionResult> GetSearchByConsumerName(string consumerName)
    {
        var consumer = await _mediator.Send(new GetConsumersBySearchQuery { ConsumerName = consumerName });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }
    [HttpGet("{consumerPhoneNumber}")]
    public async Task<IActionResult> GetSearchByPhoneNumber(string consumerPhoneNumber)
    {
        var consumer = await _mediator.Send(new GetConsumersByPhoneQuery { PhoneNumber = consumerPhoneNumber });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{searchDate}")]
    public async Task<IActionResult> GetSearchByDate(DateTime searchDate)
    {
        var consumer = await _mediator.Send(new GetConsumersByDateQuery { SearchDate = searchDate });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpGet("{startDate}/{endDate}")]
    public async Task<IActionResult> GetSearchByDateBetween(DateTime startDate, DateTime endDate)
    {
        var consumer = await _mediator.Send(new GetConsumerByDateBetweenQuery { StartDate = startDate, EndDate = endDate });
        if (consumer is not null) { return Ok(consumer); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateConsumerCommand command)
    {
        await _mediator.Send(command);
        return Ok("Consumer Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateConsumerCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(int Id)
    {
        await _mediator.Send(new DeleteConsumerCommand { Id = Id });
        return NoContent();
    }
}