using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BookCaveProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult result = validator.Validate(writer);

            if (result.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "deneme";
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Review");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
