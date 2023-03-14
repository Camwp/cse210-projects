public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string eRsvpEmail) : base(title, description, date, time, address)
    {
        rsvpEmail = eRsvpEmail;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}RSVP Email: {rsvpEmail}";
    }
}