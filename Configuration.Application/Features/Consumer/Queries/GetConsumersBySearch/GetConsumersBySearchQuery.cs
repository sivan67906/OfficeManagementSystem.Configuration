using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumersBySearch
{
    public class GetConsumersBySearchQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public string? ConsumerName { get; set; }
    }
}