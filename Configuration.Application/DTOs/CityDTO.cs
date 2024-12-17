namespace Configuration.Application.DTOs;

public class CityDTO
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public int StateId { get; set; }
    public string? StateName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }
}