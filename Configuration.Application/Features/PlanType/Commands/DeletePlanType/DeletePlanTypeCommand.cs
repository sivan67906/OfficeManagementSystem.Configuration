using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.DeletePlanType
{
    public class DeletePlanTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}


















































