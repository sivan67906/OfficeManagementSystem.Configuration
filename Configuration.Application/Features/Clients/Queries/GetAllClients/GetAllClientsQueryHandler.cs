using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Feauters.Clients.Queries.GetAllClients
{
    public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, IEnumerable<ClientDTO>>
    {
        private readonly IGenericRepository<Client> _repository;
        public GetAllClientsQueryHandler(IGenericRepository<Client> repository) => _repository = repository;

        public async Task<IEnumerable<ClientDTO>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _repository.GetAllAsync();

            var clientlist = clients.Select(x => new ClientDTO
            {
                Id = x.Id,
                ClientName = x.ClientName,
                ClientCode = x.ClientCode,
                Description = x.Description,
                Email = x.Email,
                CompanyName = x.CompanyName,
                PhoneNumber = x.PhoneNumber,
                Address1 = x.Address1,
                Address2 = x.Address2,
                Country = x.Country,
                State = x.State,
                City = x.City,
                ZipCode = x.ZipCode
            }).ToList();

            return clientlist;
        }
    }
}


