using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.CreateBusinessLocation;

public class CreateBusinessLocationCommand : IRequest
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int CompanyId { get; set; }
    public int AddressId { get; set; }
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }
    public string TaxName { get; set; } = string.Empty;
    public string TaxNumber { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
