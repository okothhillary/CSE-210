using System;

public class Event
{
    private string _eventName;
    private DateTime _eventDate;
    private Address _eventLocation;

    public Event(string name, DateTime date, Address location)
    {
        _eventName = name;
        _eventDate = date;
        _eventLocation = location;
    }

    public string GetEventDetails()
    {
        return $"{_eventName} on {_eventDate.ToShortDateString()} at {_eventLocation}";
    }
}
