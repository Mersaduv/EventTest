using EventTest.Models;

namespace EventTest.Repositories
{
    public interface IEventRepository
    {
        List<Event> GetEvents();
        Event? GetEvent(Guid id);
        Event AddEvent(Event @event);
    }
}