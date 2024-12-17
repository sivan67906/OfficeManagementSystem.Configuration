using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Categories.Commands.CreateCategory;

internal class CreateCategoryCommandHandler(
    IGenericRepository<Category> categoryRepository) : IRequestHandler<CreateCategoryCommand>
{
    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category
        {

        };

        await categoryRepository.CreateAsync(category);
    }
}








