using CalendarApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalendarApp1.Controllers
{
    public class CalendarController : Controller
    {
        [HttpGet]
        public JsonResult GetMonth(CalendarModel model)
        {
            // Get event data from the selected month
            // Update selected month
            model.SelectedMonth += 1;
            // return month data
            return Json(model);
        }
    }
}
