using Configuration.Application.DTOs;
using Configuration.Application.Services;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumersBySearch;

internal class GetConsumersBySearchQueryHandler : IRequestHandler<GetConsumersBySearchQuery, IEnumerable<ConsumerDTO>>
{
    private readonly IConsumerService _consumerService;

    public GetConsumersBySearchQueryHandler(IConsumerService consumerService) =>
       _consumerService = consumerService;

    public async Task<IEnumerable<ConsumerDTO>> Handle(GetConsumersBySearchQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerService.SearchConsumersByNameAsync(request.ConsumerName);
        if (consumer == null || !consumer.Any()) return null;

        var consumers = consumer.Select(x => new ConsumerDTO
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            Password = x.Password,
            PlanTypeId = x.PlanTypeId,
            PlanTypeName = x.PlanType.Name,
            PhoneNumber = x.PhoneNumber,
            Website = x.Website,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return consumers;
    }
}
