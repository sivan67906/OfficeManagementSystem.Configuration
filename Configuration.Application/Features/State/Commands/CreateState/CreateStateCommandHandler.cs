using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.States.Commands.CreateState;

internal class CreateStateCommandHandler(
    IGenericRepository<State> stateRepository) : IRequestHandler<CreateStateCommand>
{
    public async Task Handle(CreateStateCommand request, CancellationToken cancellationToken)
    {
        var state = new State
        {
            Code = request.Code,
            Name = request.Name,
            CountryId = request.CountryId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await stateRepository.CreateAsync(state);
    }
}












