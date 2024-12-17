using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumerByDateBetween
{
    public class GetSearchConsumerByDateBetweenQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
