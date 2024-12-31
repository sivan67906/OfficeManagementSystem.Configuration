using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Settings.Domain.Entities;

namespace Configuration.Domain.Entities;

public sealed class Company
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string RegnNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int EstablishedYear { get; set; }
    public string Website { get; set; } = string.Empty;
    public int BusinessTypeId { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(BusinessTypeId))]
    public BusinessType? BusinessType { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public BusinessCategory? Category { get; set; }
    public ICollection<BusinessLocation>? BusinessLocations { get; set; }
    public ICollection<Department>? Departments { get; set; }
    public ICollection<Designation>? Designations { get; set; }
    public ICollection<Role>? Roles { get; set; }

}
