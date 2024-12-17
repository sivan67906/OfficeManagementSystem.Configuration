using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Categories.Queries.GetAllCategories;

internal class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<CategoryDTO>>
{
    private readonly IGenericRepository<Category> _categoryRepository;

    public GetAllCategoriesQueryHandler(
        IGenericRepository<Category> categoryRepository) =>
        _categoryRepository = categoryRepository;

    public async Task<IEnumerable<CategoryDTO>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _categoryRepository.GetAllAsync();

        var categoryList = companies.Select(x => new CategoryDTO
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return categoryList;
    }
}








