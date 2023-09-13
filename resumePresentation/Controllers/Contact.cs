using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
