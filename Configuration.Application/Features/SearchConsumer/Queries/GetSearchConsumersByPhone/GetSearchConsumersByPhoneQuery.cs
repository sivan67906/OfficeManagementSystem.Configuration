using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetSearchConsumersByPhone
{
    public class GetSearchConsumersByPhoneQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public string? PhoneNumber { get; set; }
    }
}
