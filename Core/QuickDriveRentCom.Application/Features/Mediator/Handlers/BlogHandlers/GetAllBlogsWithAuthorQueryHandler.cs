using QuickDriveRentCom.Application.Features.Mediator.Queries.BlogQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.BlogResults;
using QuickDriveRentCom.Application.Interfaces.BlogInterfaces;
using QuickDriveRentCom.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler:IRequestHandler<GetAllBlogsWithAuthorQuery , List<GetAllBlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _repository;

    public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
                var values = _repository.GetLast3BlogsWithAuthors();
                return values.Select(x => new GetAllBlogsWithAuthorQueryResult
                {
                    Id = x.Id,
                    AuthorId = x.AuthorId,
                    CategoryId = x.CategoryId,
                    CoverImgUrl = x.CoverImgUrl,
                    CreatedDateTime = x.CreatedDateTime,
                    Title = x.Title,
                    AuthorName = x.Author.Name,
                    Description = x.Description,
                    AuthorDesc=x.Author.Description,
                    AuthorImgUrl = x.Author.ImgUrl
                    
                }).ToList();
        }
    }
}
