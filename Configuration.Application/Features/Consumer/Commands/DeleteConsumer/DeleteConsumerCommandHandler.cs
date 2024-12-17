using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Consumers.Commands.DeleteConsumer;

internal class DeleteConsumerCommandHandler : IRequestHandler<DeleteConsumerCommand>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public DeleteConsumerCommandHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;
    public async Task Handle(DeleteConsumerCommand request, CancellationToken cancellationToken)
    {
        await _consumerRepository.DeleteAsync(request.Id);
    }
}
