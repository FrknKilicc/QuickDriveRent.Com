using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.LocationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationQueryResult>>
    {
    }
}
