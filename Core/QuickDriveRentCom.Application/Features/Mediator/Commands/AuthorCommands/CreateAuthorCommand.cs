using MediatR;
using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommand:IRequest
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public string CoverImgUrl { get; set; }
    }
}
