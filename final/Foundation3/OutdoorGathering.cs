public class OutdoorGathering : Event
{
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string eWeatherStatement) : base(title, description, date, time, address)
    {
        weatherStatement = eWeatherStatement;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}Weather Statement: {weatherStatement}";
    }
}