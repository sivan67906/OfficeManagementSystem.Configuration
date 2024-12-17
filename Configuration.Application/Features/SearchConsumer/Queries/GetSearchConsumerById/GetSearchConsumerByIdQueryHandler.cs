using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumerById;

internal class GetSearchConsumerByIdQueryHandler : IRequestHandler<GetSearchConsumerByIdQuery, ConsumerDTO>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public GetSearchConsumerByIdQueryHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;

    public async Task<ConsumerDTO> Handle(GetSearchConsumerByIdQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerRepository.GetByIdAsync(request.Id);
        if (consumer == null) return null;
        return new ConsumerDTO
        {
            Id = consumer.Id,
            FirstName = consumer.FirstName,
            LastName = consumer.LastName,
            Email = consumer.Email,
            Password = consumer.Password,
            PlanTypeId = consumer.PlanTypeId,
            PhoneNumber = consumer.PhoneNumber,
            Website = consumer.Website,
            Description = consumer.Description,
            CreatedDate = consumer.CreatedDate,
            UpdatedDate = consumer.UpdatedDate,
            IsActive = consumer.IsActive
        };
    }
}
