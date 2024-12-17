using MediatR;
using Configuration.Application.DTOs;

namespace Configuration.Application.Feauters.Clients.Queries.GetClientById
{
    public class GetClientByIdQuery : IRequest<ClientDTO>
    {
        public int Id { get; set; }
    }
}


