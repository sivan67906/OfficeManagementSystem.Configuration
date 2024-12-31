using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.PlanTypes.Queries.GetPlanTypeById;

internal class GetPlanTypeByIdQueryHandler : IRequestHandler<GetPlanTypeByIdQuery, PlanTypeDTO>
{
    private readonly IGenericRepository<PlanType> _planTypeRepository;

    public GetPlanTypeByIdQueryHandler(
        IGenericRepository<PlanType> planTypeRepository) =>
        _planTypeRepository = planTypeRepository;

    public async Task<PlanTypeDTO> Handle(GetPlanTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var planType = await _planTypeRepository.GetByIdAsync(request.Id);
        if (planType == null) return null;
        return new PlanTypeDTO
        {
            Id = planType.Id,
            Code = planType.Code,
            Name = planType.Name
        };
    }
}


















































