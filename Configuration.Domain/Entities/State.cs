using System.ComponentModel.DataAnnotations.Schema;

namespace Configuration.Domain.Entities;

public class State
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(CountryId))]
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public ICollection<City> Cities { get; set; } = new List<City>();
}