using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
