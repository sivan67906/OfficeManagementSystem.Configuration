using Configuration.Application.Features.Companies.Commands.DeleteCompany;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;
using MediatR;

namespace Configuration.Application.Features.Companys.Commands.DeleteCompany;

internal class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
{
    private readonly IGenericRepository<Company> _companyRepository;

    public DeleteCompanyCommandHandler(
        IGenericRepository<Company> companyRepository) =>
        _companyRepository = companyRepository;
    public async Task Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
    {
        await _companyRepository.DeleteAsync(request.Id);
    }
}
