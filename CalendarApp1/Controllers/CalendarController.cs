using CalendarApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalendarApp1.Controllers
{
    public class CalendarController : Controller
    {
        [HttpGet]
        public ActionResult GetMonth(CalendarModel model, bool next)
        {
            // Get event data from the selected month
            // Update selected month
            model.SelectedDate = model.SelectedDate.AddMonths(next ? 1 : -1);

            // return month data
            return PartialView(model);
        }
    }
}
