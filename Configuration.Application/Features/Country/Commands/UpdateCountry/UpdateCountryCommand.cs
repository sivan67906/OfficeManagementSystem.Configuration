using MediatR;

namespace Configuration.Application.Features.Countries.Commands.UpdateCountry;

public class UpdateCountryCommand : IRequest
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public DateTime UpdatedDate { get; set; }
}












