using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Commands.AuthorCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);

            values.Name = request.Name;
            values.Description = request.Description;
            values.ImgUrl = request.ImgUrl;
            
            await _repository.UpdateAsync(values);
        }
    }
}
