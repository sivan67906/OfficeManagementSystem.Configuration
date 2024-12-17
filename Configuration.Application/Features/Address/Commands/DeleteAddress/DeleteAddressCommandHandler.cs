using MediatR;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Addresses.Commands.DeleteAddress;

internal class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
{
    private readonly IGenericRepository<Address> _addressRepository;

    public DeleteAddressCommandHandler(
        IGenericRepository<Address> addressRepository) =>
        _addressRepository = addressRepository;
    public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
    {
        await _addressRepository.DeleteAsync(request.Id);
    }
}












