using Configuration.Domain.Entities;
using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Queries.GetBusinessTypeById
{
    public class GetBusinessTypeByIdQuery : IRequest<BusinessTypeDTO>
    {
        public int Id { get; set; }
    }
}





