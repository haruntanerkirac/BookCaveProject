using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
