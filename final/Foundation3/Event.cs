public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string eTitle, string eDescription, DateTime eDate, TimeSpan eTime, Address eAddress)
    {
        title = eTitle;
        description = eDescription;
        date = eDate;
        time = eTime;
        address = eAddress;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.ToString()}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n";
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name} - {title} ({date.ToShortDateString()})";
    }
}