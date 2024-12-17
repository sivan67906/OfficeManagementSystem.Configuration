using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Designations.Commands.DeleteDesignation;

internal class DeleteDesignationCommandHandler : IRequestHandler<DeleteDesignationCommand>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public DeleteDesignationCommandHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;
    public async Task Handle(DeleteDesignationCommand request, CancellationToken cancellationToken)
    {
        await _designationRepository.DeleteAsync(request.Id);
    }
}




