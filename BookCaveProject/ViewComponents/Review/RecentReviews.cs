using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.ViewComponents.Review
{
    public class RecentReviews : ViewComponent
    {
        ReviewManager reviewManager = new ReviewManager(new EfReviewRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = reviewManager.GetReviewListWithWriter(id).Take(3);
            return View(values);
        }
    }
}
