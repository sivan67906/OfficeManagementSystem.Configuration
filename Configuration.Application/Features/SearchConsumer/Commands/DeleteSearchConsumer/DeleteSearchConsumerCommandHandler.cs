using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Commands.DeleteSearchConsumer;

internal class DeleteSearchConsumerCommandHandler : IRequestHandler<DeleteSearchConsumerCommand>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public DeleteSearchConsumerCommandHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;
    public async Task Handle(DeleteSearchConsumerCommand request, CancellationToken cancellationToken)
    {
        await _consumerRepository.DeleteAsync(request.Id);
    }
}
