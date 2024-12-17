using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.States.Commands.UpdateState;

internal class UpdateStateCommandHandler : IRequestHandler<UpdateStateCommand>
{
    private readonly IGenericRepository<State> _stateRepository;

    public UpdateStateCommandHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;

    public async Task Handle(UpdateStateCommand request, CancellationToken cancellationToken)
    {
        var state = new State
        {
            Id = request.Id,
            Name = request.Name,
            Code = request.Code,
            CountryId = request.CountryId,
            UpdatedDate = request.UpdatedDate
        };

        await _stateRepository.UpdateAsync(state);
    }
}












