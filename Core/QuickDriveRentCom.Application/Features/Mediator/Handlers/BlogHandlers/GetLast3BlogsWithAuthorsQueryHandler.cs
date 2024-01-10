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
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                Id = x.Id,
                AuthorId = x.AuthorId,

                CategoryId = x.CategoryId,
                CoverImgUrl = x.CoverImgUrl,
                CreatedDateTime = x.CreatedDateTime,
                Title = x.Title,
                AuthorName=x.Author.Name
            }).ToList();
        }
    }
}
