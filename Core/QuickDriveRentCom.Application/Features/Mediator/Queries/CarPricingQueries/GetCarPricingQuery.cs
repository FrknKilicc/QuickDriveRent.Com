using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.CarPricingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Queries.CarPricingQueries
{
    public class GetCarPricingQuery:IRequest<List<GetCarPricingQueryResult>>
    {
    }
}
