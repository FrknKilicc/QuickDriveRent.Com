using MediatR;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand:IRequest
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CategoryId { get; set; }
    }
}
