using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.PlanTypes.Commands.DeletePlanType;

internal class DeletePlanTypeCommandHandler : IRequestHandler<DeletePlanTypeCommand>
{
    private readonly IGenericRepository<PlanType> _planTypeRepository;

    public DeletePlanTypeCommandHandler(
        IGenericRepository<PlanType> planTypeRepository) =>
        _planTypeRepository = planTypeRepository;
    public async System.Threading.Tasks.Task Handle(DeletePlanTypeCommand request, CancellationToken cancellationToken)
    {
        await _planTypeRepository.DeleteAsync(request.Id);
    }
}


















































