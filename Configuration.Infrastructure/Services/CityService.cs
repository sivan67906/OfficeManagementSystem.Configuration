using Configuration.Application.Services;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Infrastructure.Services;

public class CityService(IGenericRepository<City> cityRepository)
    : ICityService
{
    public async Task<IEnumerable<City>> GetCitiesByParentId(int stateId)
    {
        var cities = await cityRepository.GetAllAsync();
        return cities.Where(x => x.StateId == stateId && x.IsActive == true);
    }
}
