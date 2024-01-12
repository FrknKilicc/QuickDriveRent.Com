using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickDriveRentCom.Application.Features.RepositoryPattern;
using QuickDriveRentDomain.Entities;

namespace QuickDriveRentComWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentRepository;

        public CommentsController(IGenericRepository<Comment> commentRepository)
        {
            _commentRepository = commentRepository;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentRepository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment Comment)
        {
            _commentRepository.Create(Comment);
            return Ok("Yorum Başarıyla Eklendi");    
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value = _commentRepository.GetById(id);
            _commentRepository.Remove(value);
            return Ok("Yorum Başarıyla silindi");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment Comment)
        {
            _commentRepository.Update(Comment);
            return Ok("Yorum Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentRepository.GetById(id);
            return Ok(values);
        }
    }
}
