using QuickDriveRentCom.Application.Features.CQRS.Commands.CategoryCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> reporsitory)
        {
            _repository = reporsitory;
        }
        public async Task Handle(UpdateCategoryCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CategoryID);

            values.Name = command.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
