using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Categories.Queries.GetCategoryById;

internal class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CategoryDTO>
{
    private readonly IGenericRepository<Category> _categoryRepository;

    public GetCategoryByIdQueryHandler(
        IGenericRepository<Category> categoryRepository) =>
        _categoryRepository = categoryRepository;

    public async Task<CategoryDTO> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(request.Id);
        if (category == null) return null;
        return new CategoryDTO
        {
        };
    }
}








