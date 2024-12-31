using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.CreatePlanType;

internal class CreatePlanTypeCommandHandler(
    IGenericRepository<PlanType> planTypeRepository) : IRequestHandler<CreatePlanTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreatePlanTypeCommand request, CancellationToken cancellationToken)
    {
        var planType = new PlanType
        {
            Code = request.Code,
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await planTypeRepository.CreateAsync(planType);
    }
}


















































