using System;

namespace ON.MobileApp.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string DatePretty { get => Date.ToString("MMMM dd, yyyy h:mm tt"); }
    }
}