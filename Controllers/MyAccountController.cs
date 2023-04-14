using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
