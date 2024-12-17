using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.CreateBusinessLocation;

internal class CreateBusinessLocationCommandHandler(
    IGenericRepository<BusinessLocation> businessLocationRepository) : IRequestHandler<CreateBusinessLocationCommand>
{
    public async Task Handle(CreateBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        var businessLocation = new BusinessLocation
        {
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

        await businessLocationRepository.CreateAsync(businessLocation);
    }
}
