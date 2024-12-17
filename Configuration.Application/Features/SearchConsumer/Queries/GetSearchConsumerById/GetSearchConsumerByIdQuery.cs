using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumerById
{
    public class GetSearchConsumerByIdQuery : IRequest<ConsumerDTO>
    {
        public int Id { get; set; }
    }
}
