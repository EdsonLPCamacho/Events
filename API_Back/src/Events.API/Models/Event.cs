namespace Events.API.Models
{
    public class Event
    {
        public int EventID { get; set; } 
        public string Local { get; set; }
        public string DataEvent { get; set; }
        public string Theme { get; set; }
        public int QttPeople { get; set; }
        public string Batch { get; set; }
        public string ImageURL { get; set; }
    }
}
