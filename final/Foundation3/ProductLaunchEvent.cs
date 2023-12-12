using System;

public class ProductLaunchEvent : Event
{
    private string _productName;

    public ProductLaunchEvent(string name, DateTime date, Address location, string product)
        : base(name, date, location)
    {
        _productName = product;
    }

    public string GetProductMessage()
    {
        return $"Exciting news! We are launching our new product '{_productName}' at {GetEventDetails()}";
    }
}
