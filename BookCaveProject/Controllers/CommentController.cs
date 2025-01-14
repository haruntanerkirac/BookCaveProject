using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.ReviewID = 1;
            commentManager.CommentAdd(comment);
            return PartialView();
        }
    }
}
