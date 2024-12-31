using Configuration.Domain.Interfaces;
using MediatR;
using Settings.Domain.Entities;

namespace Configuration.Application.Features.BusinessCategories.Commands.DeleteBusinessCategory;

internal class DeleteBusinessCategoryCommandHandler : IRequestHandler<DeleteBusinessCategoryCommand>
{
    private readonly IGenericRepository<BusinessCategory> _businessCategoryRepository;

    public DeleteBusinessCategoryCommandHandler(
        IGenericRepository<BusinessCategory> businessCategoryRepository) =>
        _businessCategoryRepository = businessCategoryRepository;
    public async Task Handle(DeleteBusinessCategoryCommand request, CancellationToken cancellationToken)
    {
        await _businessCategoryRepository.DeleteAsync(request.Id);
    }
}









