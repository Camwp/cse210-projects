class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer newCustomer)
    {
        customer = newCustomer;
        products = new List<Product>();
    }

    public double TotalCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetPrice();
        }
        if (customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += "Product Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Name: " + customer.GetName() + "\n" + customer.GetAddress();
        return shippingLabel;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
}