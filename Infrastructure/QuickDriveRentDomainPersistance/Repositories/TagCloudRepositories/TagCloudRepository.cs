using QuickDriveRentCom.Application.Interfaces.TagCloudInterfaces;
using QuickDriveRentDomain.Entities;
using QuickDriveRentDomainPersistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentDomainPersistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly QuickDriveRentComContext _context;

        public TagCloudRepository(QuickDriveRentComContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudsByBlogId(int id)
        {
            var values = _context.TagClouds.Where(x => x.BlogId == id).ToList();
            return values;
        }
    }
}
