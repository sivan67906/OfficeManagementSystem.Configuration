using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Designations.Queries.GetDesignationById;

internal class GetDesignationByIdQueryHandler : IRequestHandler<GetDesignationByIdQuery, DesignationDTO>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public GetDesignationByIdQueryHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;

    public async Task<DesignationDTO> Handle(GetDesignationByIdQuery request, CancellationToken cancellationToken)
    {
        var designation = await _designationRepository.GetByIdAsync(request.Id);
        if (designation == null) return null;
        return new DesignationDTO
        {
            Id = designation.Id,
            Code = designation.Code,
            Name = designation.Name,
            CompanyId = designation.CompanyId,
            DepartmentId = designation.DepartmentId,
            Description = designation.Description,
            CreatedDate = designation.CreatedDate,
            UpdatedDate = designation.UpdatedDate,
            IsActive = designation.IsActive
        };
    }
}




