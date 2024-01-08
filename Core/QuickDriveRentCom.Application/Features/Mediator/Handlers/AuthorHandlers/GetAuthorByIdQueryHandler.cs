using MediatR;
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
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                Id=values.Id,
                Name = values.Name,
                Description=values.Description,
                ImgUrl=values.ImgUrl,
            };
        }
    }
}
