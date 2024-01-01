using QuickDriveRentCom.Application.Features.CQRS.Results.CarResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentCom.Application.Interfaces.CarInterfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.CarHandler
{
    public class GetLast5CarsWithBrandQueryHandler
    {
       
            private readonly ICarRepository _repository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
            {
                var values =  _repository.GetLast5CarsWithBrand();
                return values.Select(x => new GetCarWithBrandQueryResult
                {

                    BrandID = x.BrandID,
                    BrandName = x.Brand.Name,
                    BigImageUrl = x.BigImageUrl,
                    CarID = x.CarID,
                    CoverImageUrl = x.CoverImageUrl,
                    Fuel = x.Fuel,
                    KM = x.KM,
                    Luggage = x.Luggage,
                    Model = x.Model,
                    Seat = x.Seat,
                    Transmission = x.Transmission

                }).ToList();
            }
        }
}
