using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetAllSearchConsumers;

internal class GetAllSearchConsumersQueryHandler : IRequestHandler<GetAllSearchConsumersQuery, IEnumerable<ConsumerDTO>>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public GetAllSearchConsumersQueryHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;

    public async Task<IEnumerable<ConsumerDTO>> Handle(GetAllSearchConsumersQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerRepository.GetAllAsync();

        var consumers = consumer.Select(x => new ConsumerDTO
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

        return consumers;
    }
}
