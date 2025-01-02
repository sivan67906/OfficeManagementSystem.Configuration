using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumerById;

internal class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, ConsumerDTO>
{
    private readonly IGenericRepository<Consumer> _consumerRepository;

    public GetCompanyByIdQueryHandler(
        IGenericRepository<Consumer> consumerRepository) =>
        _consumerRepository = consumerRepository;

    public async Task<ConsumerDTO> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerRepository.GetByIdAsync(request.Id);
        if (consumer is null) return null;
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
