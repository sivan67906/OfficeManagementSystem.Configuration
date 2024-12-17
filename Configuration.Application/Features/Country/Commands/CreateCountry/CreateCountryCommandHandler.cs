using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Countries.Commands.CreateCountry;

internal class CreateCountryCommandHandler(
    IGenericRepository<Country> countryRepository) : IRequestHandler<CreateCountryCommand>
{
    public async Task Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = new Country
        {
            Code = request.Code,
            Name = request.Name,
            CreatedDate = request.CreatedDate,
            IsActive = request.IsActive
        };

        await countryRepository.CreateAsync(country);
    }
}












