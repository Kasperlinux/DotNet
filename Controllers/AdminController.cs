using Microsoft.AspNetCore.Mvc;

namespace Bt.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
