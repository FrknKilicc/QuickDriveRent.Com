using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Commands.BlogCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);

            
            values.CreatedDateTime = request.CreatedDateTime;
            values.Title = request.Title;
            values.CoverImgUrl = request.CoverImgUrl;
            values.CategoryId = request.CategoryId;
            values.AuthorId = request.AuthorId;
            await _repository.UpdateAsync(values);
        }
    }
}
