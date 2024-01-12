using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentCom.Dto.BlogDtos
{
    public class ResultAllBlogsWithAuthorDto
    {
            public int Id { get; set; }
            public string title { get; set; }
            public int authorId { get; set; }
            public string authorName { get; set; }
            public int categoryName { get; set; }
            public string coverImgUrl { get; set; }
            public DateTime createdDateTime { get; set; }
            public int categoryId { get; set; }
             public string Description { get; set; }
             public string AuthorDesc { get; set; }
            public string AuthorImgUrl { get; set; }


    }
}
