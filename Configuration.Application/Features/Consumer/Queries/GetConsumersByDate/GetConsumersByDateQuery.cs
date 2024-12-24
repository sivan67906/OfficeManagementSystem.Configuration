using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumersByDate
{
    public class GetConsumersByDateQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public DateTime SearchDate { get; set; }
    }
}


