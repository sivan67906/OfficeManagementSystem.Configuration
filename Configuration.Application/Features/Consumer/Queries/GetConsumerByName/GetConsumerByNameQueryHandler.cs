using Configuration.Application.DTOs;
using Configuration.Application.Services;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumerByName;

internal class GetConsumerByNameQueryHandler : IRequestHandler<GetConsumerByNameQuery, ConsumerDTO>
{
    private readonly IConsumerService _consumerService;

    public GetConsumerByNameQueryHandler(IConsumerService consumerService) =>
        _consumerService = consumerService;

    public async Task<ConsumerDTO> Handle(GetConsumerByNameQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerService.GetByConsumerNameAsync(request.ConsumerName);
        if (consumer == null) return null;
        return new ConsumerDTO
        {
            Id = consumer.Id,
            FirstName = consumer.FirstName,
            LastName = consumer.LastName,
            Email = consumer.Email,
            Password = consumer.Password,
            PlanTypeId = consumer.PlanTypeId,
            PlanTypeName = consumer.PlanType.Name,
            PhoneNumber = consumer.PhoneNumber,
            Website = consumer.Website,
            Description = consumer.Description,
            CreatedDate = consumer.CreatedDate,
            UpdatedDate = consumer.UpdatedDate,
            IsActive = consumer.IsActive
        };
    }
}
