using System;

public class ProductLaunchEvent : Event
{
    private string productName;

    public ProductLaunchEvent(string name, DateTime date, Address location, string product)
        : base(name, date, location)
    {
        productName = product;
    }

    public string GetProductMessage()
    {
        return $"Exciting news! We are launching our new product '{productName}' at {GetEventDetails()}";
    }
}
