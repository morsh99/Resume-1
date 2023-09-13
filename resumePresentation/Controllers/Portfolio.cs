using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
	public class Portfolio : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
