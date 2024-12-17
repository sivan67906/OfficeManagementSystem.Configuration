using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByName
{
    public class GetSearchConsumersByNameQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public string? ConsumerName { get; set; }
    }
}
