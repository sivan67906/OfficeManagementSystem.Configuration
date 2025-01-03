using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.States.Queries.GetStateById;

internal class GetStateByIdQueryHandler : IRequestHandler<GetStateByIdQuery, StateDTO>
{
    private readonly IGenericRepository<State> _stateRepository;

    public GetStateByIdQueryHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;

    public async Task<StateDTO> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
    {
        var state = await _stateRepository.GetByIdAsync(request.Id);
        if (state == null) return null;
        return new StateDTO
        {
            Id = state.Id,
            Code = state.Code,
            Name = state.Name,
            CountryId = state.CountryId,
            CreatedDate = state.CreatedDate,
            UpdatedDate = state.UpdatedDate,
            IsActive = state.IsActive
        };
    }
}












