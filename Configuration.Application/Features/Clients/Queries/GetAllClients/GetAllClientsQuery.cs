using MediatR;
using Configuration.Application.DTOs;

namespace Configuration.Application.Feauters.Clients.Queries.GetAllClients
{
    public class GetAllClientsQuery : IRequest<IEnumerable<ClientDTO>>
    {

    }
}


