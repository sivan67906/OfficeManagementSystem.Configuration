using Configuration.Application.DTOs;
using MediatR;

namespace Configuration.Application.Features.Companies.Queries.GetAllCompanies;

public class GetAllCompaniesQuery : IRequest<IEnumerable<CompanyDTO>>
{
}
