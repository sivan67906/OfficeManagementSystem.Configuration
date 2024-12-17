using Configuration.Domain.Entities;
using MediatR;

namespace Configuration.Application.Features.Countries.Queries.GetCountryById
{
    public class GetCountryByIdQuery : IRequest<CountryDTO>
    {
        public int Id { get; set; }
    }
}












