using Microsoft.AspNetCore.Mvc;

namespace IsabellePalmdahl.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult WebDevelopment() {
			return View(); 
		}

		public IActionResult AppDevelopment()
		{
			return View();
		}

		public IActionResult GraphicDesign()
		{
			return View();
		}

		public IActionResult Marketing()
		{
			return View();
		}

		public IActionResult LeadGeneration()
		{
			return View();
		}
	}
}
