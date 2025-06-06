namespace CalendarApp1.Models
{
    public class CalendarModel
    {
        private readonly string[] _month_names = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

        private int[] _rows = [];

        private int _selectedMonth;
        
        public int[] Rows { get { return this._rows; } set { this._rows = value; } }

        public int SelectedMonth { get { return this._selectedMonth; } set { this._selectedMonth = value; } }

        public string SelectedMonthName { get { return this._month_names[this.SelectedMonth]; } }

        public CalendarModel(int[] rows, DateTime selectedMonth)
        {
            this._rows = rows;
            this._selectedMonth = selectedMonth.Month;
        }
    }
}
