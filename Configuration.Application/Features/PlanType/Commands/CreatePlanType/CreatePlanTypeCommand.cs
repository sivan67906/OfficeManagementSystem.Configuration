using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.CreatePlanType;

public class CreatePlanTypeCommand : IRequest
{
    public string? Code { get; set; }
    public string? Name { get; set; }
}


















































