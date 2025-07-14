using EventEase.Models;
public class EventService
{
    public List<Event> Events { get; set; } = new List<Event>{
        new Event(1, "Cricket World Cup 2025", "8 teams, 1 Champion!")
    };

    public void add(string name, string description)
    {
        Events.Add(new Event(Events.Count + 1, name, description, "01/12/2025"));
    }

    public List<Event> get()
    {
        return Events;
    }

}