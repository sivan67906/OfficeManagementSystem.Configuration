using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.UpdatePlanType;

internal class UpdatePlanTypeCommandHandler : IRequestHandler<UpdatePlanTypeCommand>
{
    private readonly IGenericRepository<PlanType> _planTypeRepository;

    public UpdatePlanTypeCommandHandler(
        IGenericRepository<PlanType> planTypeRepository) =>
        _planTypeRepository = planTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdatePlanTypeCommand request, CancellationToken cancellationToken)
    {
        var planType = new PlanType
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            UpdatedDate = DateTime.Now
        };

        await _planTypeRepository.UpdateAsync(planType);
    }
}


















































