using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Feauters.Clients.Queries.GetClientById
{
    public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientDTO>
    {
        private readonly IGenericRepository<Client> _repository;
        public GetClientByIdQueryHandler(IGenericRepository<Client> repository) => _repository = repository;

        public async Task<ClientDTO> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
        {
            var client = await _repository.GetByIdAsync(request.Id);
            if (client == null) return null;
            return new ClientDTO
            {
                Id = client.Id,
                ClientName = client.ClientName,
                ClientCode = client.ClientCode,
                Description = client.Description,
                Email = client.Email,
                CompanyName = client.CompanyName,
                PhoneNumber = client.PhoneNumber,
                Address1 = client.Address1,
                Address2 = client.Address2,
                Country = client.Country,
                State = client.State,
                City = client.City,
                ZipCode = client.ZipCode
            };
        }
    }
}


