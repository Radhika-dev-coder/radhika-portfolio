using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class PortfollioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
