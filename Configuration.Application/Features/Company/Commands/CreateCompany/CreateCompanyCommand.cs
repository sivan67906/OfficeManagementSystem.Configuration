using MediatR;

namespace Configuration.Application.Features.Companies.Commands.CreateCompany;

public class CreateCompanyCommand : IRequest
{
    public string? Name { get; set; }
    public string? RegnNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int EstablishedYear { get; set; }
    public string? Website { get; set; }
    public int BusinessTypeId { get; set; }
    public int CategoryId { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
