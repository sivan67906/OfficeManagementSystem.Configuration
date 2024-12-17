using Configuration.Application.DTOs;
using Configuration.Application.Services;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByName;

internal class GetSearchConsumersByNameQueryHandler : IRequestHandler<GetSearchConsumersByNameQuery, IEnumerable<ConsumerDTO>>
{
    private readonly IConsumerService _consumerService;

    public GetSearchConsumersByNameQueryHandler(IConsumerService consumerService) =>
        _consumerService = consumerService;

    public async Task<IEnumerable<ConsumerDTO>> Handle(GetSearchConsumersByNameQuery request, CancellationToken cancellationToken)
    {
        var consumers = await _consumerService.SearchConsumersByNameAsync(request.ConsumerName);
        if (consumers == null) return null;
        var consumerList = consumers.Select(x => new ConsumerDTO
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            Password = x.Password,
            PlanTypeId = x.PlanTypeId,
            PhoneNumber = x.PhoneNumber,
            Website = x.Website,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return consumerList;
    }
}
