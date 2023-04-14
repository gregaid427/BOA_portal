using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
