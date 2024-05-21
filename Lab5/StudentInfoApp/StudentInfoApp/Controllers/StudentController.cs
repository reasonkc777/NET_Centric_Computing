using Microsoft.AspNetCore.Mvc;
using StudentInfoApp.Models;

namespace StudentInfoApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Display", model);
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult Display(StudentModel model)
        {
            return View(model);
        }
    }
}
