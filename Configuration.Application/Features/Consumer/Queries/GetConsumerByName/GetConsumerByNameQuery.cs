using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumerByName
{
    public class GetConsumerByNameQuery : IRequest<ConsumerDTO>
    {
        public string? ConsumerName { get; set; }
    }
}
