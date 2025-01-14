using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1()
        {
            return View();
        }
    }
}
