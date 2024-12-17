using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Feauters.Clients.Commands.DeleteClient
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand>
    {
        private readonly IGenericRepository<Client> _repository;
        public DeleteClientCommandHandler(IGenericRepository<Client> repository) => _repository = repository;

        public async Task Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            if (request == null || request.Id == null)
            {
                throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
            }

            await _repository.DeleteAsync(request.Id);
        }
    }
}


