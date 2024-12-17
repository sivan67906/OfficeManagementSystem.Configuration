using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Cities.Commands.DeleteCity;

internal class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
{
    private readonly IGenericRepository<City> _cityRepository;

    public DeleteCityCommandHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;
    public async Task Handle(DeleteCityCommand request, CancellationToken cancellationToken)
    {
        await _cityRepository.DeleteAsync(request.Id);
    }
}
















