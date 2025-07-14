using EventEase.Models;
public class EventService
{
    public List<Event> Events { get; set; } = new List<Event>{
        new Event(1, "Cricket World Cup 2025", "8 teams, 1 Champion!", "01/12/2025", "https://tse1.mm.bing.net/th/id/OIP.RvpXFtpgkyQhqAETu5rD5wHaEY?r=0&rs=1&pid=ImgDetMain&o=7&rm=3")
    };

    public void add(string name, string description, string date, string img)
    {
        Events.Add(new Event(Events.Count + 1, name, description, date, img));
    }

    public void add(Event e)
    {
        if(e.Id < 0)
        {
            e.Id = Events.Count + 1;
        }
        Events.Add(e);
    }

    public List<Event> get()
    {
        return Events;
    }

}