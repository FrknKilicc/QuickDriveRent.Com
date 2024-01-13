using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.BlogQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.BlogResults;
using QuickDriveRentCom.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQuery, List<GetBlogByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResult>> Handle(GetBlogByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetBlogByAuthorId(request.Id);
            return values.Select(x => new GetBlogByAuthorIdQueryResult
            {
                Id=x.Id,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                AuthorDesc = x.Author.Description,
                AuthorImgUrl = x.Author.ImgUrl

            }).ToList();
        
        }
    }
}
