using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Categories.Commands.DeleteCategory;

internal class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
{
    private readonly IGenericRepository<Category> _categoryRepository;

    public DeleteCategoryCommandHandler(
        IGenericRepository<Category> categoryRepository) =>
        _categoryRepository = categoryRepository;
    public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        await _categoryRepository.DeleteAsync(request.Id);
    }
}








