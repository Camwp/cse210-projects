public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string zipCode;

    public Address(string eStreetAddress, string eCity, string eState, string eZipCode)
    {
        streetAddress = eStreetAddress;
        city = eCity;
        state = eState;
        zipCode = eZipCode;
    }

    public override string ToString()
    {
        return $"{streetAddress}, {city}, {state} {zipCode}";
    }
}