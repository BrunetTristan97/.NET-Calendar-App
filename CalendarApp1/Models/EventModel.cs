namespace CalendarApp1.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public EventModel() { }
    }
}
