﻿using Microsoft.AspNetCore.Mvc;

namespace IsabellePalmdahl.Controllers
{
	public class PortfolioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
