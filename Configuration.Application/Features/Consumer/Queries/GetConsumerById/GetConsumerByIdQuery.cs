using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Consumers.Queries.GetConsumerById
{
    public class GetCompanyByIdQuery : IRequest<ConsumerDTO>
    {
        public int Id { get; set; }
    }
}
