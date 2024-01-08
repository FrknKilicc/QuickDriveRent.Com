using MediatR;
using QuickDriveRentCom.Application.Features.Mediator.Results.FeatureResults;
using QuickDriveRentCom.Application.Features.Mediator.Results.AuthorResults;
using QuickDriveRentCom.Application.Interfaces;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickDriveRentCom.Application.Features.Mediator.Queries.GetAuthorQueries;

namespace QuickDriveRentCom.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery,List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Id= x.Id,
                Name = x.Name,
                ImgUrl = x.ImgUrl,
                Description = x.Description,
                
            }).ToList();
        }

       

      
    }
}
