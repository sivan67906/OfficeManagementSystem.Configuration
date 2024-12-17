using MediatR;

namespace Configuration.Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityCommand : IRequest
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public int StateId { get; set; }
    public DateTime UpdatedDate { get; set; }
}
















