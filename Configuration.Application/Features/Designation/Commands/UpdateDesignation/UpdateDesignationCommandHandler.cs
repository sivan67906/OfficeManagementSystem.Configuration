using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Designations.Commands.UpdateDesignation;

internal class UpdateDesignationCommandHandler : IRequestHandler<UpdateDesignationCommand>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public UpdateDesignationCommandHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;

    public async Task Handle(UpdateDesignationCommand request, CancellationToken cancellationToken)
    {
        var designation = new Designation
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            DepartmentId = request.DepartmentId,
            Description = request.Description,
            UpdatedDate = request.UpdatedDate,
            IsActive = request.IsActive
        };

        await _designationRepository.UpdateAsync(designation);
    }
}




