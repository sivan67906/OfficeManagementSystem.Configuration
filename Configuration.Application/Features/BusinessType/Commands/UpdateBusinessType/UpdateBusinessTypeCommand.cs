using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.UpdateBusinessType;

public class UpdateBusinessTypeCommand : IRequest
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
}





