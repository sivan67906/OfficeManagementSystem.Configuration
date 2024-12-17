using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetAllConsumers;

public class GetAllConsumersQuery : IRequest<IEnumerable<ConsumerDTO>>
{
}
