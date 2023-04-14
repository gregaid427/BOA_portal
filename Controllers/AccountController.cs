using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
