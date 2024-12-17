using MediatR;
using Configuration.Application.DTOs;
using Configuration.Application.Services;

namespace Configuration.Application.Features.States.Queries.GetStatesByParentId;
public class GetStatesByParentIdQueryHandler : IRequestHandler<GetStatesByParentIdQuery, IEnumerable<StateDTO>>
{
    private readonly IStateService _stateService;

    public GetStatesByParentIdQueryHandler(IStateService stateService)
    {
        _stateService = stateService;
    }
    public async Task<IEnumerable<StateDTO>> Handle(GetStatesByParentIdQuery request, CancellationToken cancellationToken)
    {
        var states = await _stateService.GetStatesByParentId(request.CountryId);
        if (states == null || !states.Any()) return null;

        var consumers = states.Select(x => new StateDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            CountryId = x.CountryId,
            //CountryName = x.Country.Name,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return consumers;
    }
}
