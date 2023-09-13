using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
	public class Blog : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
