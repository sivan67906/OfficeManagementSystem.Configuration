using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Roles.Queries.GetRoleById
{
    public class GetRoleByIdQuery : IRequest<RoleDTO>
    {
        public int Id { get; set; }
    }
}



