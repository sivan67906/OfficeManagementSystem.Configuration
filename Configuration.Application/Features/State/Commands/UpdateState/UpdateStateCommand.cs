using MediatR;

namespace Configuration.Application.Features.States.Commands.UpdateState;

public class UpdateStateCommand : IRequest
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public int CountryId { get; set; }
    public DateTime UpdatedDate { get; set; }
}












