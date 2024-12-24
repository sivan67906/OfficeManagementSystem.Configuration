using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumersByPhone
{
    public class GetConsumersByPhoneQuery : IRequest<IEnumerable<ConsumerDTO>>
    {
        public string? PhoneNumber { get; set; }
    }
}


