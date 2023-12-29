using QuickDriveRentCom.Application.Features.CQRS.Queries.BrandQueries;
using QuickDriveRentCom.Application.Features.CQRS.Queries.CarQueries;
using QuickDriveRentCom.Application.Features.CQRS.Results.BrandResults;
using QuickDriveRentCom.Application.Features.CQRS.Results.CarResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetCarByIdQueryHandler
    {

        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BrandID = values.BrandID,
                BigImageUrl=values.BigImageUrl,
                CoverImageUrl=values.CoverImageUrl,
                Fuel=values.Fuel,
                CarID=values.CarID,
                KM = values.KM,
                Luggage=values.Luggage,
                Seat=values.Seat,   
                Model=values.Model,
                Transmission = values.Transmission  
            };
        }
    }
}
