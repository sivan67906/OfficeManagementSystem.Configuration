using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.BusinessCategories.Queries.GetBusinessCategoryById
{
    public class GetBusinessCategoryByIdQuery : IRequest<BusinessCategoryDTO>
    {
        public int Id { get; set; }
    }
}









