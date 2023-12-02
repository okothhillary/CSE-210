using System;
using System.Collections.Generic;

class Program
{
    static void Main(string []args)
    {
        // Create an address
        Address customerAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create a customer
        Customer customer = new Customer("John Doe", customerAddress);

        // Create products
        Product product1 = new Product("Product A", 1, 10.99m, 2);
        Product product2 = new Product("Product B", 2, 19.99m, 1);

        // Create a list of products
        List<Product> products = new List<Product> { product1, product2 };

        // Create an order
        Order order = new Order(products, customer, 5.00m);

        // Display order information
        Console.WriteLine("Order Information:");
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
        Console.WriteLine(order.GeneratePackingLabel());
        Console.WriteLine(order.GenerateShippingLabel());
    }
}
