namespace CalendarApp1.Models
{
    public class CalendarModel
    {
        private readonly string[] _month_names = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        private DateTime _selectedDate;

        //private List<EventModel> _events = new List<EventModel>();
        public int[][] Rows { 
            get {
                int firstDayOfWeek = (int)SelectedDate.DayOfWeek;
                int lastDayOfWeek = (int)new DateTime(SelectedDate.Year, SelectedDate.Month, DateTime.DaysInMonth(SelectedDate.Year, SelectedDate.Month)).DayOfWeek;

                int[] days = Enumerable.Range(1, DateTime.DaysInMonth(SelectedDate.Year, SelectedDate.Month)).ToArray();

                List<int> calendarMonth = new int[firstDayOfWeek].Concat(days).Concat(new int[6 - lastDayOfWeek]).ToList();

                return calendarMonth.Chunk(7).ToArray();
            } 
        }

        public DateTime SelectedDate { get { return this._selectedDate; } set { this._selectedDate = value; } }

        public string SelectedMonthName { get { return this._month_names[this.SelectedDate.Month - 1]; } }

        public List<EventModel> Events { get; set; }

        public CalendarModel() {
            this.SelectedDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            // TODO: Call service function to list all events for the selected month
            this.Events = new List<EventModel>();
        }
    }
}
