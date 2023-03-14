class Customer {
    private string name;
    private Address address;

    public Customer(string custName, Address custAddress) {
        name = custName;
        address = custAddress;
    }

    public string GetName() {
        return name;
    }

    public string GetAddress() {
        return address.GetFullAddress();
    }

    public bool IsInUSA() {
        return address.IsInUSA();
    }
}