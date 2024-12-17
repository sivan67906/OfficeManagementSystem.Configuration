using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Departments.Queries.GetAllDepartments;

public class GetAllDepartmentsQuery : IRequest<IEnumerable<DepartmentDTO>>
{

}
