using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Addresses.Queries.GetAllAddresses;

internal class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQuery, IEnumerable<AddressDTO>>
{
    private readonly IGenericRepository<AddressDTO> _addressRepository;

    public GetAllAddressesQueryHandler(
        IGenericRepository<AddressDTO> addressRepository) =>
        _addressRepository = addressRepository;

    public async Task<IEnumerable<AddressDTO>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _addressRepository.GetAllAsync();

        var addressList = companies.Select(x => new AddressDTO
        {
            Id = x.Id,
            Address1 = x.Address1,
            Address2 = x.Address2,
            ZipCode = x.ZipCode,
            Latitude = x.Latitude,
            Longitude = x.Longitude,
            IsPrimary = x.IsPrimary,
            CreatedDate = x.CreatedDate,
            IsActive = x.IsActive,
        }).ToList();

        return addressList;
    }
}












