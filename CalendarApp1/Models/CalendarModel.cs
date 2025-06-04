namespace CalendarApp1.Models
{
    public class CalendarModel
    {
        private string[] _rows = [];


        public string[] Rows { get { return this._rows; } set { this._rows = value; } }

        public CalendarModel(string[] rows)
        {
            this._rows = rows;
        }
    }
}
