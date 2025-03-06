using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
