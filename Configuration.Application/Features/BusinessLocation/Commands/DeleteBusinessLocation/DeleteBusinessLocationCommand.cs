using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.DeleteBusinessLocation
{
    public class DeleteBusinessLocationCommand : IRequest
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public string TaxName { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string Latitude { get; set; } = string.Empty;
        public string Longitude { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
