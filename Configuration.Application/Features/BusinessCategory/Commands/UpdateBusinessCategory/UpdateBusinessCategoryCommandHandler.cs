using Configuration.Domain.Interfaces;
using MediatR;
using Settings.Domain.Entities;

namespace Configuration.Application.Features.BusinessCategories.Commands.UpdateBusinessCategory;

internal class UpdateBusinessCategoryCommandHandler : IRequestHandler<UpdateBusinessCategoryCommand>
{
    private readonly IGenericRepository<BusinessCategory> _businessCategoryRepository;

    public UpdateBusinessCategoryCommandHandler(
        IGenericRepository<BusinessCategory> businessCategoryRepository) =>
        _businessCategoryRepository = businessCategoryRepository;

    public async Task Handle(UpdateBusinessCategoryCommand request, CancellationToken cancellationToken)
    {
        var businessCategory = new BusinessCategory
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            BusinessTypeId = request.BusinessTypeId,
            UpdatedDate = DateTime.Now
        };

        await _businessCategoryRepository.UpdateAsync(businessCategory);
    }
}









