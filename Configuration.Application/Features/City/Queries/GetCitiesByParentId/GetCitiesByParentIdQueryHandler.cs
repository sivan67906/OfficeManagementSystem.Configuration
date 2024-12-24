using Configuration.Application.DTOs;
using Configuration.Application.Features.Cities.Queries.GetCitiesByParentId;
using Configuration.Application.Services;
using MediatR;

namespace Configuration.Application.Features.Citys.Queries.GetCitysByParentId;
public class GetCitiesByParentIdQueryHandler : IRequestHandler<GetCitiesByParentIdQuery, IEnumerable<CityDTO>>
{
    private readonly ICityService _cityService;

    public GetCitiesByParentIdQueryHandler(ICityService cityService)
    {
        _cityService = cityService;
    }
    public async Task<IEnumerable<CityDTO>> Handle(GetCitiesByParentIdQuery request, CancellationToken cancellationToken)
    {
        var cities = await _cityService.GetCitiesByParentId(request.StateId);
        if (cities == null || !cities.Any()) return null;

        var cityList = cities.Select(x => new CityDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            StateId = x.StateId,
            //CountryName = x.Country.Name,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return cityList;
    }
}
