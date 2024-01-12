using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Dto.AuthorDtos
{
    public class ResultGetAuthorByBlogAuthorIdDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDesc { get; set; }
        public string AuthorImgUrl { get; set; }
    }
}
