using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Departments.Commands.DeleteDepartment;

internal class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public DeleteDepartmentCommandHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;
    public async Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        await _departmentRepository.DeleteAsync(request.Id);
    }
}
