using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumerByDateBetween
{
    public class GetConsumerByDateBetweenQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}


