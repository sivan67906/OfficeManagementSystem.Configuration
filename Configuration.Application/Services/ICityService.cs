using Configuration.Domain.Entities;

namespace Configuration.Application.Services;

public interface ICityService
{
    Task<IEnumerable<City>> GetCitiesByParentId(int stateId);
}
