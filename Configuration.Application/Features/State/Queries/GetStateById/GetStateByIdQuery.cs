using MediatR;
using Configuration.Application.DTOs;

namespace Configuration.Application.Features.States.Queries.GetStateById
{
    public class GetStateByIdQuery : IRequest<StateDTO>
    {
        public int Id { get; set; }
    }
}












