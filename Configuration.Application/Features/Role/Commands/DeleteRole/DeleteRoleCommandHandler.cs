using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Roles.Commands.DeleteRole;

internal class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
{
    private readonly IGenericRepository<Role> _roleRepository;

    public DeleteRoleCommandHandler(
        IGenericRepository<Role> roleRepository) =>
        _roleRepository = roleRepository;
    public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        await _roleRepository.DeleteAsync(request.Id);
    }
}



