using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Commands.UpdateSearchConsumer;

internal class UpdateSearchConsumerCommandHandler : IRequestHandler<UpdateSearchConsumerCommand>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public UpdateSearchConsumerCommandHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;

    public async Task Handle(UpdateSearchConsumerCommand request, CancellationToken cancellationToken)
    {
        var consumer = new Consumer
        {
            Id = request.Id,
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

        await _consumerRepository.UpdateAsync(consumer);
    }
}
