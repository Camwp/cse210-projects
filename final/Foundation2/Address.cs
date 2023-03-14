class Address {
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string lblStreetAddress, string lblCity, string lblState, string lblCountry) {
        streetAddress = lblStreetAddress;
        city = lblCity;
        state = lblState;
        country = lblCountry;
    }

    public bool IsInUSA() {
        return country == "USA";
    }

    public string GetFullAddress() {
        return streetAddress + "\n" + city + ", " + state + " " + country;
    }
}