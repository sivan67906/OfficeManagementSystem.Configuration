using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Designations.Queries.GetDesignationById
{
    public class GetDesignationByIdQuery : IRequest<DesignationDTO>
    {
        public int Id { get; set; }
    }
}




