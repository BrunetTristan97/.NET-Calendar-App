namespace CalendarApp1.Models
{
    public class CalendarModel
    {
        private readonly string[] _month_names = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        private int[] _rows = [];

        private DateTime _selectedDate;
        
        public int[] Rows { 
            get {
                return Enumerable.Range(1, DateTime.DaysInMonth(SelectedDate.Year, SelectedDate.Month)).ToArray();
            } 
        }

        public DateTime SelectedDate { get { return this._selectedDate; } set { this._selectedDate = value; } }

        public string SelectedMonthName { get { return this._month_names[this.SelectedDate.Month]; } }

        public CalendarModel() { 
            this.SelectedDate = DateTime.UtcNow; 
        }
    }
}
