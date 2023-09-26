using Microsoft.AspNetCore.Mvc;

namespace resumePresentation.Controllers
{
	public class resume : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
