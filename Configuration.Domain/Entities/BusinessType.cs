using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Settings.Domain.Entities;

namespace Configuration.Domain.Entities;

public sealed class BusinessType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<Company>? Companies { get; set; }
    public ICollection<BusinessCategory>? BusinessCategories { get; set; }
}