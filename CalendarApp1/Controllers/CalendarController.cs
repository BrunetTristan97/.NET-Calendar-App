using CalendarApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalendarApp1.Controllers
{
    public class CalendarController : Controller
    {
        [HttpGet]
        public IActionResult GetMonth(string datetime, string direction)
        {
            if (direction != "next" && direction != "previous")
            {
                return BadRequest("Invalid direction parameter. Use 'next' or 'previous'.");
            }

            if (string.IsNullOrEmpty(datetime))
            {
                return BadRequest("datetime parameter is required.");
            }

            CalendarModel model = new CalendarModel();
            DateTime dateTime = DateTime.Parse(datetime).ToUniversalTime();
            model.SelectedDate = dateTime.AddMonths(direction == "next" ? 1 : -1);

            return PartialView("Views/Home/Partials/_CalendarPartial.cshtml", model);
        }
    }
}
