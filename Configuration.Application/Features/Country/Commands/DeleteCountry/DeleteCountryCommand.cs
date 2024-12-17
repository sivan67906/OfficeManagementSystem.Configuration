using MediatR;

namespace Configuration.Application.Features.Countries.Commands.DeleteCountry
{
    public class DeleteCountryCommand : IRequest
    {
        public int Id { get; set; }
    }
}












