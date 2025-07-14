namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; } = -1;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;


        public Event() {}

        public Event(int id, string name, string description, string date, string img)
        {
            if(Id < 0)
            {
                Id = id;
            }
            Name = name;
            Description = description;
            Date = date;
            Image = img;
        }
    }
}