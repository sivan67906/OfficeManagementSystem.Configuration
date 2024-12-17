using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Cities.Queries.GetAllCities;

internal class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, IEnumerable<CityDTO>>
{
    private readonly IGenericRepository<CityDTO> _cityRepository;

    public GetAllCitiesQueryHandler(
        IGenericRepository<CityDTO> cityRepository) =>
        _cityRepository = cityRepository;

    public async Task<IEnumerable<CityDTO>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _cityRepository.GetAllAsync();

        var cityList = companies.Select(x => new CityDTO
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            StateId = x.StateId,
            CreatedDate = x.CreatedDate
        }).ToList();

        return cityList;
    }
}
















