using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Companies.Queries.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {
        public int Id { get; set; }
    }
}
