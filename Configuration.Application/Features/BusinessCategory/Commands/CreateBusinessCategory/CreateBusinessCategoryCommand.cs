using MediatR;

namespace Configuration.Application.Features.BusinessCategories.Commands.CreateBusinessCategory;

public class CreateBusinessCategoryCommand : IRequest
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public int BusinessTypeId { get; set; }
}









