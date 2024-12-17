using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.DeleteBusinessType;

internal class DeleteBusinessTypeCommandHandler : IRequestHandler<DeleteBusinessTypeCommand>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public DeleteBusinessTypeCommandHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;
    public async Task Handle(DeleteBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        await _businessTypeRepository.DeleteAsync(request.Id);
    }
}





