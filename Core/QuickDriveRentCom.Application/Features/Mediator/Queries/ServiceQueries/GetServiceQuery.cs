using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery:IRequest<List<GetServiceQueryResult>>
    {
    }
}
