using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Addresses.Queries.GetAllAddresses;

public class GetAllAddressesQuery : IRequest<IEnumerable<AddressDTO>>
{
}












