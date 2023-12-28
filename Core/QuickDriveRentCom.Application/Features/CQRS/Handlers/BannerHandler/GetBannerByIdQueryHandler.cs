using QuickDriveRentCom.Application.Features.CQRS.Queries.AboutQueries;
using QuickDriveRentCom.Application.Features.CQRS.Queries.BannerQueries;
using QuickDriveRentCom.Application.Features.CQRS.Results.AboutResults;
using QuickDriveRentCom.Application.Features.CQRS.Results.BannerResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.BannerHandler
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerID = values.BannerID,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
                Title = values.Title,
                Description = values.Description,
            };
        }

    }
}

