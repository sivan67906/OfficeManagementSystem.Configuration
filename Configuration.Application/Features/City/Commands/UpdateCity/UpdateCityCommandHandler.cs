using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Cities.Commands.UpdateCity;

internal class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand>
{
    private readonly IGenericRepository<City> _cityRepository;

    public UpdateCityCommandHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;

    public async Task Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        var city = new City
        {
            Id = request.Id,
            Name = request.Name,
            Code = request.Code,
            StateId = request.StateId,
            UpdatedDate = DateTime.UtcNow
        };

        await _cityRepository.UpdateAsync(city);
    }
}
















