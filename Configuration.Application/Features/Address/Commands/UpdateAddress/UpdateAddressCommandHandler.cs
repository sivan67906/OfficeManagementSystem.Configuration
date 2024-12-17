using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Addresses.Commands.UpdateAddress;

internal class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand>
{
    private readonly IGenericRepository<Address> _addressRepository;

    public UpdateAddressCommandHandler(
        IGenericRepository<Address> addressRepository) =>
        _addressRepository = addressRepository;

    public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Id = request.Id,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            CityId = request.CityId,
            IsPrimary = request.IsPrimary,
            UpdatedDate = request.UpdatedDate
        };

        await _addressRepository.UpdateAsync(address);
    }
}












