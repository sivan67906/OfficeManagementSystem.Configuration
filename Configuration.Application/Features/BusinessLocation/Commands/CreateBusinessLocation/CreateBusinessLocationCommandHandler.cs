using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Commands.CreateBusinessLocation;

internal class CreateBusinessLocationCommandHandler(
    IGenericRepository<BusinessLocation> businessLocationRepository,
    IGenericRepository<Address> addressRepository

    ) : IRequestHandler<CreateBusinessLocationCommand>
{
    public async Task Handle(CreateBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            CityId = request.CityId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
        var insertedAddress = await addressRepository.CreateAsyncwithEntity(address);

        var businessLocation = new BusinessLocation
        {
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            AddressId = insertedAddress.Id,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,
            TaxName = request.TaxName,
            TaxNumber = request.TaxNumber,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await businessLocationRepository.CreateAsync(businessLocation);
    }
}
