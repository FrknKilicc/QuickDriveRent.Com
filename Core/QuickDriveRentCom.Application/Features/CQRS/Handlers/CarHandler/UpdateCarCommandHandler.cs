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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> reporsitory)
        {
            _repository = reporsitory;
        }
        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);

            values.Fuel = command.Fuel;
            values.KM = command.KM;
            values.Seat = command.Seat;
            values.BigImageUrl = command.BigImageUrl;
            values.Transmission = command.Transmission;
            values.BrandID = command.BrandID;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Luggage = command.Luggage;
            values.Model = command.Model;
            await _repository.UpdateAsync(values);
        }

    }
}
