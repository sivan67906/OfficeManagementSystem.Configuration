﻿using Configuration.Application.DTOs;
using Configuration.Application.Features.Departments.Queries.GetAllDepartments;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.x.Queries.GetAllDepartments;

internal class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, IEnumerable<DepartmentDTO>>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public GetAllDepartmentsQueryHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;

    public async Task<IEnumerable<DepartmentDTO>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var departments = await _departmentRepository.GetAllAsync();

        var departmentList = departments.Select(x => new DepartmentDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            CompanyId = x.CompanyId,
            CompanyName = x.Company.Name,
            Email = x.Email,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return departmentList;
    }
}
