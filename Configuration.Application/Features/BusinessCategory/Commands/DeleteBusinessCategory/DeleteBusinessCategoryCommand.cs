using MediatR;

namespace Configuration.Application.Features.BusinessCategories.Commands.DeleteBusinessCategory
{
    public class DeleteBusinessCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
}









