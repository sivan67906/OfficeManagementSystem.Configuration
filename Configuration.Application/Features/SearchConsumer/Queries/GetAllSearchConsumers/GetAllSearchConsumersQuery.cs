using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.SearchConsumers.Queries.GetAllSearchConsumers;

public class GetAllSearchConsumersQuery : IRequest<IEnumerable<ConsumerDTO>>
{
}
