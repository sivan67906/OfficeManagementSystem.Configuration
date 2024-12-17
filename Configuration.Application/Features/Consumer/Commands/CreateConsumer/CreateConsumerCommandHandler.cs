using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Consumers.Commands.CreateConsumer;

internal class CreateConsumerCommandHandler : IRequestHandler<CreateConsumerCommand>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public CreateConsumerCommandHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;
    public async Task Handle(CreateConsumerCommand request, CancellationToken cancellationToken)
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
            IsActive = request.IsActive
        };

        await _consumerRepository.CreateAsync(consumer);
    }
}
