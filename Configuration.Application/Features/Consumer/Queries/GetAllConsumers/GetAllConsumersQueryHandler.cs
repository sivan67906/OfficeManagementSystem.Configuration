using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetAllConsumers;

internal class GetAllConsumersQueryHandler : IRequestHandler<GetAllConsumersQuery, IEnumerable<ConsumerDTO>>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public GetAllConsumersQueryHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;

    public async Task<IEnumerable<ConsumerDTO>> Handle(GetAllConsumersQuery request, CancellationToken cancellationToken)
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
            PlanTypeName = x.PlanType?.Name,
            PhoneNumber = x.PhoneNumber,
            Website = x.Website,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive,
        }).ToList();

        return consumers;
    }
}
