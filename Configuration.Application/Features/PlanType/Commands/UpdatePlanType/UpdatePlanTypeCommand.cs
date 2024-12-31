using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.UpdatePlanType;

public class UpdatePlanTypeCommand : IRequest
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
}


















































