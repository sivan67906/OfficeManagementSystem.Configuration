using MediatR;
using Settings.Application.DTOs;

namespace Configuration.Application.Features.BusinessCategories.Queries.GetAllBusinessCategories;

public class GetAllBusinessCategoriesQuery : IRequest<IEnumerable<BusinessCategoryDTO>>
{
}









