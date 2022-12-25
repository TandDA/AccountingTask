using Microsoft.AspNetCore.Mvc;

namespace AccountingTask.Controllers
{
    public class ConsumptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
