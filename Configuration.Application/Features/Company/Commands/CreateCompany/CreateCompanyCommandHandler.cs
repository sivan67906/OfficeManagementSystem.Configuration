using Configuration.Application.Features.Companies.Commands.CreateCompany;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Companys.Commands.CreateCompany;

internal class CreateCompanyCommandHandler(
    IGenericRepository<Company> companyRepository) : IRequestHandler<CreateCompanyCommand>
{
    public async Task Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        var company = new Company
        {
            Name = request.Name,
            RegnNumber = request.RegnNumber,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            EstablishedYear = request.EstablishedYear,
            Website = request.Website,
            BusinessTypeId = request.BusinessTypeId,
            CategoryId = request.CategoryId,
            Description = request.Description,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive
        };

        await companyRepository.CreateAsync(company);
    }
}
