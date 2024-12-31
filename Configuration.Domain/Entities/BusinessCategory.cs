using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Configuration.Domain.Entities;

namespace Settings.Domain.Entities;
public sealed class BusinessCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public int BusinessTypeId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<Company>? Companies { get; set; }
    [ForeignKey(nameof(BusinessTypeId))]
    public BusinessType? BusinessType { get; set; }
}






























