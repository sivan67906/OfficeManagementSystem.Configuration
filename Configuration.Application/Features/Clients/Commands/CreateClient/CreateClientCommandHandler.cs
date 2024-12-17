using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Feauters.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, int>
    {
        private readonly IGenericRepository<Client> _repository;
        public CreateClientCommandHandler(IGenericRepository<Client> repository) => _repository = repository;

        public async Task<int> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                ClientName = request.ClientName,
                ClientCode = request.ClientCode,
                Description = request.Description,
                Email = request.Email,
                CompanyName = request.CompanyName,
                PhoneNumber = request.PhoneNumber,
                Address1 = request.Address1,
                Address2 = request.Address2,
                Country = request.Country,
                State = request.State,
                City = request.City,
                ZipCode = request.ZipCode
            };

            await _repository.CreateAsync(client);
            return client.Id;
        }
    }
}


