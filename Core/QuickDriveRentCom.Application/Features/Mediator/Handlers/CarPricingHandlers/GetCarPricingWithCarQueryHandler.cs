using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.CarPricingQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.CarPricingResults;
using QuickDriveRentCom.Application.Features.Mediator.Results.LocationResults;
using QuickDriveRentCom.Application.Interfaces.CarPricingInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithCars();
            return values.Select(x => new GetCarPricingQueryResult
            {
               Amount=x.Amount,
               Brand=x.Car.Brand.Name,
               CarPricingId=x.CarPricingID,
               CoverImageUrl=x.Car.CoverImageUrl,
               Model=x.Car.Model


            }).ToList();
        }
    }
}
