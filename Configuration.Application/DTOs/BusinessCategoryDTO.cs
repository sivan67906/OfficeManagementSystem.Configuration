namespace Settings.Application.DTOs;
public class BusinessCategoryDTO
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public int BusinessTypeId { get; set; }
    public string? BusinessTypeName { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}






























