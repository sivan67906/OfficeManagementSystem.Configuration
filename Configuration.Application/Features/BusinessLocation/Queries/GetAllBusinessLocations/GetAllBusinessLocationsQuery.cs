using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Queries.GetAllBusinessLocations;

public class GetAllBusinessLocationsQuery : IRequest<IEnumerable<BusinessLocationDTO>>
{
}
