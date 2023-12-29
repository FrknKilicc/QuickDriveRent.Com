using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQueries
    {
        public int Id { get; set; }

        public GetBrandByIdQueries(int id)
        {
            Id = id;
        }
    }
}
