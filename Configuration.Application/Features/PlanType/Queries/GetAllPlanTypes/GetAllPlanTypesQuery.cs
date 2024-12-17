using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.PlanTypes.Queries.GetAllPlanTypes;

public class GetAllPlanTypesQuery : IRequest<IEnumerable<PlanTypeDTO>>
{
}
