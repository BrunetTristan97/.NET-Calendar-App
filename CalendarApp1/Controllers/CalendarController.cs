using Microsoft.AspNetCore.Mvc;

namespace CalendarApp1.Controllers
{
    public class CalendarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
