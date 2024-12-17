using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Departments.Queries.GetDepartmentById
{
    public class GetDepartmentByIdQuery : IRequest<DepartmentDTO>
    {
        public int Id { get; set; }
    }
}
