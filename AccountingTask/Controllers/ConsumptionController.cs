using AccountingTask.Areas.Identity.Data;
using AccountingTask.Data;
using AccountingTask.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AccountingTask.Controllers
{
    public class ConsumptionController : Controller
    {
        private ApplicationContext _db;
        private UserManager<ApplicationUser> _userManager;
        public ConsumptionController(ApplicationContext db, UserManager<ApplicationUser> userManager)
		{
            _db = db;
            _userManager = userManager;
		}
		[HttpPost]
        public IActionResult Index(double ConsuptionSum, string ConsuptionText)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Consumption cons = new Consumption(ConsuptionSum, ConsuptionText, userId);
            _db.Consumptions.Add(cons);
            _db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
