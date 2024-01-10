﻿using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.BlogResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetLast3BlogsWithAuthorsQuery:IRequest<List<GetLast3BlogsWithAuthorsQueryResult>>
    {
    }
}
