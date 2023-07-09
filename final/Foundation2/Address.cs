class Address
{
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string street, string city, string stateProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetAddressAsString()
    {
        return "Street: " + street + "\n" +
               "City: " + city + "\n" +
               "State/Province: " + stateProvince + "\n" +
               "Country: " + country;
    }
}