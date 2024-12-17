using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.PlanTypes.Queries.GetAllPlanTypes;

internal class GetAllPlanTypesQueryHandler : IRequestHandler<GetAllPlanTypesQuery, IEnumerable<PlanTypeDTO>>
{
    private readonly IGenericRepository<PlanType> _planTypeRepository;

    public GetAllPlanTypesQueryHandler(
        IGenericRepository<PlanType> planTypeRepository) =>
        _planTypeRepository = planTypeRepository;

    public async Task<IEnumerable<PlanTypeDTO>> Handle(GetAllPlanTypesQuery request, CancellationToken cancellationToken)
    {
        var planType = await _planTypeRepository.GetAllAsync();

        var planTypes = planType.Select(x => new PlanTypeDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name
        }).ToList();

        return planTypes;
    }
}