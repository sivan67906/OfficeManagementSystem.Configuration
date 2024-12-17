using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Commands.CreateSearchConsumer;

internal class CreateSearchConsumerCommandHandler : IRequestHandler<CreateSearchConsumerCommand>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public CreateSearchConsumerCommandHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;
    public async Task Handle(CreateSearchConsumerCommand request, CancellationToken cancellationToken)
    {
        var consumer = new Consumer
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Password = request.Password,
            PlanTypeId = request.PlanTypeId,
            PhoneNumber = request.PhoneNumber,
            Website = request.Website,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await _consumerRepository.CreateAsync(consumer);
    }
}
