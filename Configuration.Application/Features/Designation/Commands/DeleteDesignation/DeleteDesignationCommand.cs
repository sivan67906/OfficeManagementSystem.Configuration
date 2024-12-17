using MediatR;

namespace Configuration.Application.Features.Designations.Commands.DeleteDesignation
{
    public class DeleteDesignationCommand : IRequest
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}




