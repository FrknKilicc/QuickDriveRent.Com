using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand:IRequest
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
