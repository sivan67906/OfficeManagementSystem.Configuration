using MediatR;
using Configuration.Application.DTOs;

namespace Configuration.Application.Features.States.Queries.GetStatesByParentId;
public class GetStatesByParentIdQuery : IRequest<IEnumerable<StateDTO>>
{
    public int CountryId { get; set; }
}
