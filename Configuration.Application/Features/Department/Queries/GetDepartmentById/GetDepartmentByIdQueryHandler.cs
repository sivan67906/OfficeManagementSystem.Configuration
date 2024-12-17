using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Departments.Queries.GetDepartmentById;

internal class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, DepartmentDTO>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public GetDepartmentByIdQueryHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;

    public async Task<DepartmentDTO> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
    {
        var department = await _departmentRepository.GetByIdAsync(request.Id);
        if (department == null) return null;
        return new DepartmentDTO
        {
            Id = department.Id,
            Code = department.Code,
            Name = department.Name,
            CompanyId = department.CompanyId,
            Email = department.Email,
            Description = department.Description,
            CreatedDate = department.CreatedDate,
            UpdatedDate = department.UpdatedDate,
            IsActive = department.IsActive
        };
    }
}
