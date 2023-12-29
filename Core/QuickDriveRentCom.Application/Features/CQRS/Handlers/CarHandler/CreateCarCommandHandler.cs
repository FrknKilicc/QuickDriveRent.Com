using QuickDriveRentCom.Application.Features.CQRS.Commands.BrandCommands;
using QuickDriveRentCom.Application.Features.CQRS.Commands.CarCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.CarHandler
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                BigImageUrl = command.BigImageUrl,
                Transmission = command.Transmission,    
                Seat = command.Seat,    
                Model = command.Model,
                Luggage = command.Luggage,
                KM = command.KM,
                Fuel = command.Fuel,
                CoverImageUrl = command.CoverImageUrl,
                

            });
        }
    }
}
