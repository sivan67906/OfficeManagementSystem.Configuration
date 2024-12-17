using Configuration.Domain.Entities;
using MediatR;

namespace Configuration.Application.Features.Countries.Queries.GetAllCountries;

public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDTO>>
{
}












