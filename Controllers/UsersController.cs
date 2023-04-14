using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
