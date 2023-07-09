class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product { Name = "Product 1", ProductID = 1, Price = 10.99m, Quantity = 2 };
        Product product2 = new Product { Name = "Product 2", ProductID = 2, Price = 5.99m, Quantity = 3 };
        Product product3 = new Product { Name = "Product 3", ProductID = 3, Price = 8.50m, Quantity = 1 };

        // Create customers
        Customer customer1 = new Customer { Name = "Customer 1", Address = new Address("123 Main St", "Cityville", "CA", "USA") };
        Customer customer2 = new Customer { Name = "Customer 2", Address = new Address("456 Elm St", "Townsville", "NY", "USA") };

        // Create orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

        // Display packing labels, shipping labels, and total costs for orders
        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order 1 - Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order 2 - Total Cost: $" + order2.CalculateTotalCost());
    }
}