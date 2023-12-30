using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.ServiceQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.FeatureResults;
using QuickDriveRentCom.Application.Features.Mediator.Results.ServiceResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                ServiceID = x.ServiceID,
                Description = x.Description,
                IconUrl = x.IconUrl,
                Title = x.Title 
            }).ToList();
        }

       

      
    }
}
