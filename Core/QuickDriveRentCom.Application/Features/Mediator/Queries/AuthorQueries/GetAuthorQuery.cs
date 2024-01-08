using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.AuthorResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Queries.GetAuthorQueries
{
    public class GetAuthorQuery:IRequest<List<GetAuthorQueryResult> >
    {
    }
}
