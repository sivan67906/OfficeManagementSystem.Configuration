using Configuration.Domain.Interfaces;
using MediatR;
using Settings.Domain.Entities;

namespace Configuration.Application.Features.BusinessCategories.Commands.CreateBusinessCategory;

internal class CreateBusinessCategoryCommandHandler(
    IGenericRepository<BusinessCategory> businessCategoryRepository) : IRequestHandler<CreateBusinessCategoryCommand>
{
    public async Task Handle(CreateBusinessCategoryCommand request, CancellationToken cancellationToken)
    {
        var businessCategory = new BusinessCategory
        {
            Code = request.Code,
            Name = request.Name,
            BusinessTypeId = request.BusinessTypeId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await businessCategoryRepository.CreateAsync(businessCategory);
    }
}









