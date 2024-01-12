using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Dto.BlogDtos
{
    public class ResultGetBlogByIdDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImgUrl { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string AuthorDesc { get; set; }
        public string AuthorImgUrl { get; set; }
    }
}
