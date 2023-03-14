public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string eSpeakerName, int eCapacity) : base(title, description, date, time, address)
    {
        speakerName = eSpeakerName;
        capacity = eCapacity;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}Speaker: {speakerName}\nCapacity: {capacity}";
    }
}