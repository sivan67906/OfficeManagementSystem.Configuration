using MediatR;

namespace Configuration.Application.Features.Companies.Commands.UpdateCompany;

public class UpdateCompanyCommand : IRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? RegnNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int EstablishedYear { get; set; }
    public string? Website { get; set; }
    public int BusinessTypeId { get; set; }
    public int CategoryId { get; set; }
    public string? Description { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
