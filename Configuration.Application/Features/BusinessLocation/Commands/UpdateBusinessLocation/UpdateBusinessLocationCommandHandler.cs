using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.UpdateBusinessLocation;

internal class UpdateBusinessLocationCommandHandler : IRequestHandler<UpdateBusinessLocationCommand>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;

    public UpdateBusinessLocationCommandHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository) =>
        _businessLocationRepository = businessLocationRepository;

    public async Task Handle(UpdateBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        var businessLocation = new BusinessLocation
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            AddressId = request.AddressId,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,
            TaxName = request.TaxName,
            TaxNumber = request.TaxNumber,
            CreatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await _businessLocationRepository.UpdateAsync(businessLocation);
    }
}
