using System.ComponentModel.DataAnnotations.Schema;

namespace Configuration.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(CityId))]
    public int CityId { get; set; }
    public City City { get; set; } = null!;
}