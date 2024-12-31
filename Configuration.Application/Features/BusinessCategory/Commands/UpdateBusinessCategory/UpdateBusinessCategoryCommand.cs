using MediatR;

namespace Configuration.Application.Features.BusinessCategories.Commands.UpdateBusinessCategory;

public class UpdateBusinessCategoryCommand : IRequest
{
    public int Id { get; set; }
    public int BusinessTypeId { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
}









