using Microsoft.AspNetCore.Mvc;

namespace BOA_Portal.Controllers
{
    public class TransactionsSummary : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
