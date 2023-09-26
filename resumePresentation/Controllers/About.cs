using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
	public class About : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Salam()
		{
			return View();
		}
	}
}
