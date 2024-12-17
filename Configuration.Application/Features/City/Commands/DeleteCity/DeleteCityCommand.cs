using MediatR;

namespace Configuration.Application.Features.Cities.Commands.DeleteCity
{
    public class DeleteCityCommand : IRequest
    {
        public int Id { get; set; }
    }
}
















