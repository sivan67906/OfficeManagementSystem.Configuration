using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.UpdateBusinessType;

internal class UpdateBusinessTypeCommandHandler : IRequestHandler<UpdateBusinessTypeCommand>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public UpdateBusinessTypeCommandHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;

    public async Task Handle(UpdateBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        var businessType = new BusinessType
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            UpdatedDate = DateTime.Now
        };

        await _businessTypeRepository.UpdateAsync(businessType);
    }
}





