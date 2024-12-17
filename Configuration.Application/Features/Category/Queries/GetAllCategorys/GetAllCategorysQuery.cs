using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Categories.Queries.GetAllCategories;

public class GetAllCategoriesQuery : IRequest<IEnumerable<CategoryDTO>>
{
}








