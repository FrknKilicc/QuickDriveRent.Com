using QuickDriveRentCom.Application.Features.CQRS.Commands.ContactCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.ContactHandler
{
    public class UpdateContactCommandHandler
    {
       
            private readonly IRepository<Contact> _repository;

            public UpdateContactCommandHandler(IRepository<Contact> reporsitory)
            {
                _repository = reporsitory;
            }
            public async Task Handle(UpdateContactCommand command)
            {
                var values = await _repository.GetByIdAsync(command.ContactID);

                values.Name = command.Name;
                values.Email = command.Email;
                values.SendDate = command.SendDate;
                values.Subject = command.Subject;
                values.Message = command.Message;
                await _repository.UpdateAsync(values);
            }
        }
}
