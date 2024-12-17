using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByDate
{
    public class GetSearchConsumersByDateQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public DateTime SearchDate { get; set; }
    }
}
