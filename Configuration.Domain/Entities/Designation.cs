using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Configuration.Domain.Entities;

public sealed class Designation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int CompanyId { get; set; }
    public int DepartmentId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(CompanyId))]
    public Company? Company { get; set; }

    [ForeignKey(nameof(DepartmentId))]
    public Department? Department { get; set; }
    public ICollection<Role>? Roles { get; set; }
}