using Configuration.Application.Services;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Infrastructure.Services;

public class StateService(IGenericRepository<State> stateRepository)
    : IStateService
{
    public async Task<IEnumerable<State>> GetStatesByParentId(int countryId)
    {
        var states = await stateRepository.GetAllAsync();
        var finalStateList = states.Where(x => x.CountryId == countryId && x.IsActive == true);
        return finalStateList;
    }
}
