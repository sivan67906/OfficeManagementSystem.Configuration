using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Queries.GetAllBusinessTypes;

internal class GetAllBusinessTypesQueryHandler : IRequestHandler<GetAllBusinessTypesQuery, IEnumerable<BusinessTypeDTO>>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public GetAllBusinessTypesQueryHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;

    public async Task<IEnumerable<BusinessTypeDTO>> Handle(GetAllBusinessTypesQuery request, CancellationToken cancellationToken)
    {
        var businessTypes = await _businessTypeRepository.GetAllAsync();

        var businessTypeList = businessTypes.Select(x => new BusinessTypeDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name
        }).ToList();

        return businessTypeList;
    }
}





