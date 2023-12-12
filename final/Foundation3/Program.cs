using System;

class Program
{
    static void Main()
    {
        // Creating an address
        Address eventAddress = new Address
        {
            Street = "Grevillea Grove",
            City = "Nairobi",
            State = "Westlands",
            ZipCode = "00200"
        };

        // Creating events
        ProductLaunchEvent productLaunchEvent = new ProductLaunchEvent("Product Launch", DateTime.Now, eventAddress, "A.I for The World");
        SalesEvent salesEvent = new SalesEvent("Year-End Sale", DateTime.Now.AddDays(30), eventAddress, 15.5m);

        // Displaying messages
        Console.WriteLine(productLaunchEvent.GetProductMessage());
        Console.WriteLine(salesEvent.GetDiscountMessage());
    }
}
