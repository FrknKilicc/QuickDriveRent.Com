using QuickDriveRentCom.Application.Features.CQRS.Commands.AboutCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.AboutHandler
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public RemoveAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle (RemoveAboutCommand command)
        {
            var value = await _repository.GetByIdAsync (command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
