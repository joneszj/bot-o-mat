using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.Web.Models;

namespace RedVentures.Bot_O_Mat.Web.Controllers
{
    public class HomeController : Controller
    {
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
