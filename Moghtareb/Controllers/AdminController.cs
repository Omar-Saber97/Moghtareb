using Microsoft.AspNetCore.Mvc;

namespace Moghtareb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
