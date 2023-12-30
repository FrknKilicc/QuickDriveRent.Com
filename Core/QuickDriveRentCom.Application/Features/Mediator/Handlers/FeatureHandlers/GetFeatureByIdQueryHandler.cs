using MediatR;
using QuickDriveRentCom.Application.Features.CQRS.Results.AboutResults;
using QuickDriveRentCom.Application.Features.CQRS.Results.BrandResults;
using QuickDriveRentCom.Application.Features.Mediator.Queries.FeatureQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.FeatureResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler:IRequestHandler<GetFeatureByIdQuery,GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        async Task<GetFeatureByIdQueryResult> IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>.Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureID = values.FeatureID,
                Name = values.Name,
            };

        }
    }
}
