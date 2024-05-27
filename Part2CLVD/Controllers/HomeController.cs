using Microsoft.AspNetCore.Mvc;
using Part2CLVD.Models;
using System.Diagnostics;

namespace Part2CLVD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public IActionResult Purchase()
		{
			return View();
		}


		public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

      

        public IActionResult Index()
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
