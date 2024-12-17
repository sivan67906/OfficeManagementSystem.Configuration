using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Departments.Commands.UpdateDepartment;

internal class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public UpdateDepartmentCommandHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;

    public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
    {
        var department = new Department
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            Email = request.Email,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await _departmentRepository.UpdateAsync(department);
    }
}
