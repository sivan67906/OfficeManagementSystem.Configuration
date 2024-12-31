using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.CreateBusinessType;

public class CreateBusinessTypeCommand : IRequest
{
    public string? Code { get; set; }
    public string? Name { get; set; }
}





