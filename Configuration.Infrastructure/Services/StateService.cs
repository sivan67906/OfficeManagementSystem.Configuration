using Configuration.Application.Services;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Infrastructure.Services;

public class StateService(IGenericRepository<State> stateRepository)
    : IStateService
{
    public async Task<IEnumerable<State>> GetStatesByParentId(int countryId)
    {
        var consumers = await stateRepository.GetAllAsync();
        return consumers.Where(x => x.CountryId == countryId && x.IsActive == true);
    }
}
