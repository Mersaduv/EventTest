using EventTest.Models;

namespace EventTest.Repositories;

public class EventRepository : IEventRepository
{
    private static readonly List<Event> _events = new();

    static EventRepository()
    {
        _events.Add(new Event
        {
            Id = Guid.NewGuid(),
            Title = "Event 1",
            Tickets = 100,
            Venue = "Venue 1",
            StartDateTime = DateTime.Now,
            EndDateTime = DateTime.Now,
            LastModifiedDateTime = DateTimeOffset.Now,
            Description = new List<string> { "Description 1", "Description 2" }
        });
        _events.Add(new Event
        {
            Id = Guid.NewGuid(),
            Title = "Event 2",
            Tickets = 200,
            Venue = "Venue 2",
            StartDateTime = DateTime.Now,
            EndDateTime = DateTime.Now,
            LastModifiedDateTime = DateTimeOffset.Now,
            Description = new List<string> { "Description 1", "Description 2" }
        });
        _events.Add(new Event
        {
            Id = Guid.NewGuid(),
            Title = "Event 3",
            Tickets = 300,
            Venue = "Venue 3",
            StartDateTime = DateTime.Now,
            EndDateTime = DateTime.Now,
            LastModifiedDateTime = DateTimeOffset.Now,
            Description = new List<string> { "Description 1", "Description 2" }
        });
    }

    public List<Event> GetEvents()
    {
        return _events;
    }

    public Event? GetEvent(Guid id)
    {
        return _events.Find(x => x.Id == id);
    }

    public Event AddEvent(Event @event)
    {
        _events.Add(@event);
        return @event;
    }

    public Event UpdateEvent(Event @event)
    {
        var index = _events.FindIndex(x => x.Id == @event.Id);
        _events[index] = @event;
        return @event;
    }
}