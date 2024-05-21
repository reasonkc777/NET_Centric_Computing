using Microsoft.AspNetCore.Mvc;
using SimpleInterestApp.Models;

namespace SimpleInterestApp.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(SimpleInterestModel model)
        {
            model.Interest = (model.Principal * model.Rate * model.Time) / 100;
            return RedirectToAction("Result", model);
        }

        public IActionResult Result(SimpleInterestModel model)
        {
            return View(model);
        }
    }
}
