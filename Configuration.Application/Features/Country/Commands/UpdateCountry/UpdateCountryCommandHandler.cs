using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Countries.Commands.UpdateCountry;

internal class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand>
{
    private readonly IGenericRepository<Country> _countryRepository;

    public UpdateCountryCommandHandler(
        IGenericRepository<Country> countryRepository) =>
        _countryRepository = countryRepository;

    public async Task Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = new Country
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            UpdatedDate = request.UpdatedDate
        };

        await _countryRepository.UpdateAsync(country);
    }
}












