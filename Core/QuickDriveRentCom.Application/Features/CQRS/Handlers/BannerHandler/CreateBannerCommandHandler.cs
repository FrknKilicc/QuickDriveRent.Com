using QuickDriveRentCom.Application.Features.CQRS.Commands.AboutCommands;
using QuickDriveRentCom.Application.Features.CQRS.Commands.BannerCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.CQRS.Handlers.BannerHandler
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand command)
        {
            await _repository.CreateAsync(new Banner
            {
               Title = command.Title,
               Description = command.Description,   
               VideoDescription = command.VideoDescription,
               VideoUrl = command.VideoUrl,
            });
        }
    }
}
