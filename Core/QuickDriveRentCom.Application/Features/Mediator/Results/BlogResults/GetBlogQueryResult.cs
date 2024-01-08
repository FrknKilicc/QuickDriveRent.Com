using QuickDriveRentDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public List<Blog> Blogs { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CategoryId { get; set; }
    }
}
