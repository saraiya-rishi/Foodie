using Microsoft.AspNetCore.Mvc;

namespace Foodie.Controllers.Restaurant
{
    public class AddrestaurantController : Controller
    {
        public IActionResult AddRes()
        {
            return View();
        }
    }
}
