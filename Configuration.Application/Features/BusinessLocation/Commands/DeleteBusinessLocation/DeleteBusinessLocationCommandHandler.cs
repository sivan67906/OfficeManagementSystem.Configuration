using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.DeleteBusinessLocation;

internal class DeleteBusinessLocationCommandHandler : IRequestHandler<DeleteBusinessLocationCommand>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;

    public DeleteBusinessLocationCommandHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository) =>
        _businessLocationRepository = businessLocationRepository;
    public async Task Handle(DeleteBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        await _businessLocationRepository.DeleteAsync(request.Id);
    }
}
