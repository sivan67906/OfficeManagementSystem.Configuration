using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Cities.Commands.CreateCity;

internal class CreateCityCommandHandler(
    IGenericRepository<City> cityRepository) : IRequestHandler<CreateCityCommand>
{
    public async Task Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var city = new City
        {
            Code = request.Code,
            Name = request.Name,
            StateId = request.StateId,
            CreatedDate = DateTime.UtcNow,
            IsActive = true
        };

        await cityRepository.CreateAsync(city);
    }
}
















