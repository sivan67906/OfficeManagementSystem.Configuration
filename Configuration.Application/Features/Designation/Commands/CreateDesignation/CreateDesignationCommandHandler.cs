using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Designations.Commands.CreateDesignation;

internal class CreateDesignationCommandHandler(
    IGenericRepository<Designation> designationRepository) : IRequestHandler<CreateDesignationCommand>
{
    public async Task Handle(CreateDesignationCommand request, CancellationToken cancellationToken)
    {
        var designation = new Designation
        {
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            DepartmentId = request.DepartmentId,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await designationRepository.CreateAsync(designation);
    }
}




