using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.CreateBusinessType;

internal class CreateBusinessTypeCommandHandler(
    IGenericRepository<BusinessType> businessTypeRepository) : IRequestHandler<CreateBusinessTypeCommand>
{
    public async Task Handle(CreateBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        var businessType = new BusinessType
        {
            Code = request.Code,
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await businessTypeRepository.CreateAsync(businessType);
    }
}





