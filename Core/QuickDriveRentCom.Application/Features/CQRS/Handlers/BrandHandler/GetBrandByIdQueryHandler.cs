using QuickDriveRentCom.Application.Features.CQRS.Queries.BannerQueries;
using QuickDriveRentCom.Application.Features.CQRS.Queries.BrandQueries;
using QuickDriveRentCom.Application.Features.CQRS.Results.BannerResults;
using QuickDriveRentCom.Application.Features.CQRS.Results.BrandResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.BrandHandler
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQueries query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
               BrandID = values.BrandID,
               Name=values.Name,
            };
        }
    }
}
