using System;

class Program
{
        static void Main(string[] args)
        {
            // Create customer addresses
            Address customerAddress1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
            Address customerAddress2 = new Address("456 Oak St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("Cameron Pedro", customerAddress1);
            Customer customer2 = new Customer("Cash Pedro", customerAddress2);

            // Create products
            Product product1 = new Product("iPhone 13", "P001", 999.99, 1);
            Product product2 = new Product("iPad Pro", "P002", 799.99, 2);
            Product product3 = new Product("Apple Watch Series 7", "P003", 399.99, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Print packing label and shipping label for order 1
            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.PackingLabel());
            Console.WriteLine();

            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.ShippingLabel());
            Console.WriteLine();

            // Print packing label and shipping label for order 2
            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.PackingLabel());
            Console.WriteLine();

            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.ShippingLabel());
            Console.WriteLine();

            // Print total cost of order 1 and order 2
            Console.WriteLine("Order 1 Total Cost: $" + order1.TotalCost());
            Console.WriteLine("Order 2 Total Cost: $" + order2.TotalCost());
            Console.WriteLine();
        }
}