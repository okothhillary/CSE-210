using System;

public class SalesEvent : Event
{
    private decimal discountPercentage;

    public SalesEvent(string name, DateTime date, Address location, decimal discount)
        : base(name, date, location)
    {
        discountPercentage = discount;
    }

    public string GetDiscountMessage()
    {
        return $"Don't miss out on our {discountPercentage}% off sale at {GetEventDetails()}";
    }
}
