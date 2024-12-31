//using Settings.Application.DTOs;
using Configuration.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.PlanTypes.Queries.GetPlanTypeById
{
    public class GetPlanTypeByIdQuery : IRequest<PlanTypeDTO>
    {
        public int Id { get; set; }
    }
}


















































