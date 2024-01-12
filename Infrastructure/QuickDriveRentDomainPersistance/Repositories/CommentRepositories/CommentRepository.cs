using QuickDriveRentCom.Application.Features.RepositoryPattern;
using QuickDriveRentDomain.Entities;
using QuickDriveRentDomainPersistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDriveRentDomainPersistance.Repositories.CommentRepositories
{
    public class CommentRepository <T> : IGenericRepository<Comment>
    {
        private readonly QuickDriveRentComContext _context;

        public CommentRepository(QuickDriveRentComContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<Comment> GetAll()
        {
           return _context.Comments.Select(x=> new Comment
           {
               CommentId = x.CommentId,
               BlogId = x.BlogId,
               CreatedDate = x.CreatedDate,
               Description = x.Description,
               Name = x.Name,
           }).ToList();
        }

        public Comment GetById(int id)
        {
           return _context.Comments.Find(id);
        }

        public void Remove(Comment entity)
        {
            var values = _context.Comments.Find(entity.CommentId);
            _context.Remove(values);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
            _context.Comments.Update(entity);
            _context.SaveChanges();
        }
    }
}
