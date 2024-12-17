﻿using MediatR;
using Configuration.Application.DTOs;
using Configuration.Domain.Entities;
using Configuration.Domain.Interfaces;

namespace Configuration.Application.Features.Companies.Queries.GetAllCompanies;

internal class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, IEnumerable<CompanyDTO>>
{
    private readonly IGenericRepository<Company> _companyRepository;

    public GetAllCompaniesQueryHandler(
        IGenericRepository<Company> companyRepository) =>
        _companyRepository = companyRepository;

    public async Task<IEnumerable<CompanyDTO>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _companyRepository.GetAllAsync();

        var companyList = companies.Select(x => new CompanyDTO
        {
            Id = x.Id,
            Name = x.Name,
            RegnNumber = x.RegnNumber,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber,
            EstablishedYear = x.EstablishedYear,
            Website = x.Website,
            BusinessTypeId = x.BusinessTypeId,
            CategoryId = x.CategoryId,
            BusinessTypeName = x.BusinessType?.Name,
            CategoryName = x.Category?.Name,
            Description = x.Description,
            CreatedDate = x.CreatedDate
        }).ToList();

        return companyList;
    }
}
