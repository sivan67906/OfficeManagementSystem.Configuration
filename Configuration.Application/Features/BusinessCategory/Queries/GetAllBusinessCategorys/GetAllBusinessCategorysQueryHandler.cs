using Configuration.Domain.Interfaces;
using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;

namespace Configuration.Application.Features.BusinessCategories.Queries.GetAllBusinessCategories;

internal class GetAllBusinessCategoriesQueryHandler : IRequestHandler<GetAllBusinessCategoriesQuery, IEnumerable<BusinessCategoryDTO>>
{
    private readonly IGenericRepository<BusinessCategory> _businessCategoryRepository;

    public GetAllBusinessCategoriesQueryHandler(
        IGenericRepository<BusinessCategory> businessCategoryRepository) =>
        _businessCategoryRepository = businessCategoryRepository;

    public async Task<IEnumerable<BusinessCategoryDTO>> Handle(GetAllBusinessCategoriesQuery request, CancellationToken cancellationToken)
    {
        var businessCategories = await _businessCategoryRepository.GetAllAsync();

        var businessCategoryList = businessCategories.Select(x => new BusinessCategoryDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            BusinessTypeId = x.BusinessTypeId,
            BusinessTypeName = x.BusinessType.Name
        }).ToList();

        return businessCategoryList;
    }
}









