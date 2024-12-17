using MediatR;

namespace Configuration.Application.Features.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}



