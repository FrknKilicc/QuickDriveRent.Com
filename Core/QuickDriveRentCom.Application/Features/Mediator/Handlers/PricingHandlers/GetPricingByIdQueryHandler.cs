using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.PricingQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.FeatureResults;
using QuickDriveRentCom.Application.Features.Mediator.Results.PricingResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetPricingByIdQueryResult
            {
               PricingID= values.PricingID,
                Name = values.Name,
            };
        }
    }
}
