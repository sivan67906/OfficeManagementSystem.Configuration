using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Categories.Queries.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<CategoryDTO>
    {
        public int Id { get; set; }
    }
}








