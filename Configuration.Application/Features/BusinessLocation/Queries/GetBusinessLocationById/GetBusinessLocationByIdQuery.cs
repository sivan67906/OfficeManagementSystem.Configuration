using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.BusinessLocations.Queries.GetBusinessLocationById
{
    public class GetBusinessLocationByIdQuery : IRequest<BusinessLocationDTO>
    {
        public int Id { get; set; }
    }
}
