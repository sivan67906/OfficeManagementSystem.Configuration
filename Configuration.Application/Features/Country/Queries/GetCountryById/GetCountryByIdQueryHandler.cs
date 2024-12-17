using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Countries.Queries.GetCountryById;

internal class GetCountryByIdQueryHandler : IRequestHandler<GetCountryByIdQuery, CountryDTO>
{
    private readonly IGenericRepository<CountryDTO> _countryRepository;

    public GetCountryByIdQueryHandler(
        IGenericRepository<CountryDTO> countryRepository) =>
        _countryRepository = countryRepository;

    public async Task<CountryDTO> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.GetByIdAsync(request.Id);
        if (country == null) return null;
        return new CountryDTO
        {
            Id = country.Id,
            Name = country.Name,
            Code = country.Code,
            CreatedDate = country.CreatedDate,
            UpdatedDate = country.UpdatedDate,
            IsActive = country.IsActive
        };
    }
}












