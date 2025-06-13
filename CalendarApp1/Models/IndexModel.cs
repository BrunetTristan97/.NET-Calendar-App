namespace CalendarApp1.Models
{
    public class IndexModel
    {

        private CalendarModel _calendarModel;

        public CalendarModel Calendar { get { return this._calendarModel; } }

        public IndexModel ()
        {
            this._calendarModel = new CalendarModel();
        }
    }
}
