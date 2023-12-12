using System;

public class SalesEvent : Event
{
    private decimal _discountPercentage;

    public SalesEvent(string name, DateTime date, Address location, decimal discount)
        : base(name, date, location)
    {
        _discountPercentage = discount;
    }

    public string GetDiscountMessage()
    {
        return $"Don't miss out on our {_discountPercentage}% off sale at {GetEventDetails()}";
    }
}
