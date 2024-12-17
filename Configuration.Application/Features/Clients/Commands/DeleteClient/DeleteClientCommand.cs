using MediatR;

namespace Configuration.Application.Feauters.Clients.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest
    {
        public int Id { get; set; }
    }
}


