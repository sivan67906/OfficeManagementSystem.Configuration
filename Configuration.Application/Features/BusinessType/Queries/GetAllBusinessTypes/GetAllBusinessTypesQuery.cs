using Configuration.Domain.Entities;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Queries.GetAllBusinessTypes;

public class GetAllBusinessTypesQuery : IRequest<IEnumerable<BusinessTypeDTO>>
{
}





