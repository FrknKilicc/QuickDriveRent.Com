using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.FooterAddressQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.FooterAddressResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler :IRequestHandler<GetFooterAddressQuery,List<GetFooterAddressQueryResult>>

    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                Adress = x.Adress,
                Description = x.Description,
                Email = x.Email,
                Phone = x.Phone,
                FooterAddressID = x.FooterAddressID,
            }).ToList();
        }
    }
}
