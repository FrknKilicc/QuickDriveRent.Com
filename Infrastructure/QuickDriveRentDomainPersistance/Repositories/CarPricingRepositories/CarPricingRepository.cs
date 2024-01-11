using Microsoft.EntityFrameworkCore;
using QuickDriveRentCom.Application.Interfaces.CarPricingInterfaces;
using QuickDriveRentDomain.Entities;
using QuickDriveRentDomainPersistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentDomainPersistance.Repositories.CarPricingRepositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly QuickDriveRentComContext _context;

        public CarPricingRepository(QuickDriveRentComContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x=>x.Car).ThenInclude(y=>y.Brand).Include(x=>x.Pricing).Where(z=>z.PricingID==2).ToList();
            return values;
        }

     
    }
}
