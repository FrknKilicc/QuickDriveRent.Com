using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Commands.BlogCommands;
using QuickDriveRentCom.Application.Features.Mediator.Commands.FeatureCommands;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler: IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                AuthorId = request.AuthorId,
                CategoryId = request.CategoryId,    
                Title = request.Title,
                CoverImgUrl = request.CoverImgUrl,
                CreatedDateTime = request.CreatedDateTime,
            });
        }
    }
}
