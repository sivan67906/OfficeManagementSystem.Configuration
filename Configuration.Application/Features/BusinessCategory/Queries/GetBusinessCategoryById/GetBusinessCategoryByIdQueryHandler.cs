using Configuration.Domain.Interfaces;
using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;

namespace Configuration.Application.Features.BusinessCategories.Queries.GetBusinessCategoryById;

internal class GetBusinessCategoryByIdQueryHandler : IRequestHandler<GetBusinessCategoryByIdQuery, BusinessCategoryDTO>
{
    private readonly IGenericRepository<BusinessCategory> _businessCategoryRepository;

    public GetBusinessCategoryByIdQueryHandler(
        IGenericRepository<BusinessCategory> businessCategoryRepository) =>
        _businessCategoryRepository = businessCategoryRepository;

    public async Task<BusinessCategoryDTO> Handle(GetBusinessCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var businessCategory = await _businessCategoryRepository.GetByIdAsync(request.Id);
        if (businessCategory == null) return null;
        return new BusinessCategoryDTO
        {
            Id = businessCategory.Id,
            Code = businessCategory.Code,
            Name = businessCategory.Name,
            BusinessTypeId = businessCategory.BusinessTypeId,
            BusinessTypeName = businessCategory.BusinessType.Name
        };
    }
}









