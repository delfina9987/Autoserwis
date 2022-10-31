using Autoserwis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autoserwis.Controllers
{
    public class ViewModel
    {
        public DateTime CustomerCarDateDayTime { get; set; }
    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewModel vm = new ViewModel() { CustomerCarDateDayTime = DateTime.Now };
            return View(vm);
            //return View();
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