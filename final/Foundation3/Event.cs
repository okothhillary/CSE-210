using System;

public class Event
{
    private string eventName;
    private DateTime eventDate;
    private Address eventLocation;

    public Event(string name, DateTime date, Address location)
    {
        eventName = name;
        eventDate = date;
        eventLocation = location;
    }

    public string GetEventDetails()
    {
        return $"{eventName} on {eventDate.ToShortDateString()} at {eventLocation}";
    }
}
