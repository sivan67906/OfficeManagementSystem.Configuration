using Configuration.Domain.Entities;

namespace Configuration.Application.Services;

public interface IStateService
{
    Task<IEnumerable<State>> GetStatesByParentId(int countryId);
}
