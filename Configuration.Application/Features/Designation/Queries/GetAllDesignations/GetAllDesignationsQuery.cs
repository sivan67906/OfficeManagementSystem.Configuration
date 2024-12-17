using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Designations.Queries.GetAllDesignations;

public class GetAllDesignationsQuery : IRequest<IEnumerable<DesignationDTO>>
{
}




