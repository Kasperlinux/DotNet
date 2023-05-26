using Microsoft.AspNetCore.Mvc;

namespace Bt.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
