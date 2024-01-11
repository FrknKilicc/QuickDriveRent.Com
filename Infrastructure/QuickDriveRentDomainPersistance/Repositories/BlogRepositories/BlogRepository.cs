using Microsoft.EntityFrameworkCore;
using QuickDriveRentCom.Application.Interfaces.BlogInterfaces;
using QuickDriveRentDomain.Entities;
using QuickDriveRentDomainPersistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentDomainPersistance.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly QuickDriveRentComContext _context;

        public BlogRepository(QuickDriveRentComContext context)
        {
            _context = context;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values = _context.Blogs.Include(b => b.Author).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
           var values = _context.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.Id).Take(3).ToList();
            return values;
        }
    }
}
