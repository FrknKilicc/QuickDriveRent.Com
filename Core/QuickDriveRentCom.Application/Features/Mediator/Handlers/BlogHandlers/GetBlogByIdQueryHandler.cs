using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Queries.BlogQueries;
using QuickDriveRentCom.Application.Features.Mediator.Results.FeatureResults;
using QuickDriveRentCom.Application.Features.Mediator.Results.BlogResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {

             Title= values.Title,
             AuthorId= values.AuthorId,
             Id= values.Id,
             CoverImgUrl= values.CoverImgUrl,
             CreatedDateTime= values.CreatedDateTime,
             CategoryId= values.CategoryId,
             Description= values.Description,

            
               
            };

        }
    }
}
