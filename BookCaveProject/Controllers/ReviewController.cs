using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.Controllers
{
    public class ReviewController : Controller
    {
        ReviewManager reviewManager = new ReviewManager(new EfReviewRepository());
        public IActionResult Index()
        {
            var values = reviewManager.GetAllReviews();
            return View(values);
        }

        public IActionResult ReadAllReviews(int id)
        {
            ViewBag.i = id;
            var values = reviewManager.GetReviewById(id);
            return View(values);
        }
    }
}
