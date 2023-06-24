using IsabellePalmdahl.Models;
using IsabellePalmdahl.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IsabellePalmdahl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDbRepository _repo;

        public HomeController(ILogger<HomeController> logger, IDbRepository repo)
        {
            _logger = logger;
			_repo = repo;
        }

        public IActionResult Index()
        {
            //delete later
            //var client = await _repo.GetClientAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}