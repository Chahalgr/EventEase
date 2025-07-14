using EventEase.Models;
public class EventService
{
    public List<Event> Events { get; set; } = new List<Event>{
        new Event(1, "Cricket World Cup 2025", "8 teams, 1 Champion!", "01/12/2025", "https://tse1.mm.bing.net/th/id/OIP.RvpXFtpgkyQhqAETu5rD5wHaEY?r=0&rs=1&pid=ImgDetMain&o=7&rm=3")
    };

    public void add(string name, string description, string date, string img)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(date) ||
            !DateTime.TryParseExact(date, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _) 
            || string.IsNullOrWhiteSpace(description))
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(img))
        {
            img = "https://th.bing.com/th/id/R.c62ac83ee279aaeb77464c545e1d330a?rik=fmsdkS6UFpex0g&riu=http%3a%2f%2fclipartmag.com%2fimages%2foops-emoticon-4.jpg&ehk=VigMrniR44COuiN2v1g4rmABx74eE%2bIVRD0dmDUajLw%3d&risl=&pid=ImgRaw&r=0";
        }

        Events.Add(new Event(Events.Count + 1, name, description, date, img));
    }

    public void add(Event e)
    {
        if (e == null || string.IsNullOrWhiteSpace(e.Name) || string.IsNullOrWhiteSpace(e.Date) 
            || !DateTime.TryParseExact(e.Date, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out _)
            || string.IsNullOrWhiteSpace(e.Description))
        {
            return;
        }

        if (string.IsNullOrWhiteSpace(e.Image))
        {
            e.Image = "https://th.bing.com/th/id/R.c62ac83ee279aaeb77464c545e1d330a?rik=fmsdkS6UFpex0g&riu=http%3a%2f%2fclipartmag.com%2fimages%2foops-emoticon-4.jpg&ehk=VigMrniR44COuiN2v1g4rmABx74eE%2bIVRD0dmDUajLw%3d&risl=&pid=ImgRaw&r=0";
        }
            
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