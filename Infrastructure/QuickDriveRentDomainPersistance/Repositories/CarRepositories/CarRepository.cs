using Microsoft.EntityFrameworkCore;
using QuickDriveRentCom.Application.Interfaces.CarInterfaces;
using QuickDriveRentDomain.Entities;
using QuickDriveRentDomainPersistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentDomainPersistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly QuickDriveRentComContext _context;

        public CarRepository(QuickDriveRentComContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
            
        }

        public List<Car> GetLast5CarsWithBrand()
        {
            var values = _context.Cars.Include(_x => _x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;
        }
    }
}
