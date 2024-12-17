using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Roles.Queries.GetAllRoles;

public class GetAllRolesQuery : IRequest<IEnumerable<RoleDTO>>
{
}



