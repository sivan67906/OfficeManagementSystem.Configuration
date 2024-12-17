using Configuration.Application.Feauters.Clients.Commands.CreateClient;
using Configuration.Application.Feauters.Clients.Commands.DeleteClient;
using Configuration.Application.Feauters.Clients.Commands.UpdateClient;
using Configuration.Application.Feauters.Clients.Queries.GetAllClients;
using Configuration.Application.Feauters.Clients.Queries.GetClientById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Configuration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator) => _mediator = mediator;


        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int Id)
        {
            var product = await _mediator.Send(new GetClientByIdQuery { Id = Id });
            if (product is not null) { return Ok(product); }
            return NotFound();
        }


        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateClientCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, command);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateClientCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var consumerList = await _mediator.Send(new GetAllClientsQuery());
            return Ok(consumerList);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            await _mediator.Send(new DeleteClientCommand { Id = Id });
            return NoContent();
        }
    }
}
