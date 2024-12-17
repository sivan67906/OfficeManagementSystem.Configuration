using MediatR;
using Configuration.Application.DTOs;

namespace Configuration.Application.Features.Cities.Queries.GetCityById
{
    public class GetCityByIdQuery : IRequest<CityDTO>
    {
        public int Id { get; set; }
    }
}
















