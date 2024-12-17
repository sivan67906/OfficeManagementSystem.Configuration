using MediatR;

namespace Configuration.Application.Features.BusinessTypes.Commands.DeleteBusinessType
{
    public class DeleteBusinessTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}





