namespace EventTest.Mappers
{
    public static class EventMapper
    {
        public static Contracts.EventTest.EventTestResponse MapToEventTestResponse(EventTest.Models.Event @event)
        {
            return new Contracts.EventTest.EventTestResponse(
                @event.Id,
                @event.Title,
                @event.Tickets,
                @event.Venue,
                @event.StartDateTime,
                @event.EndDateTime,
                @event.LastModifiedDateTime,
                @event.Description);
        }

        public static EventTest.Models.Event MapToEvent(Contracts.EventTest.CreateEventTestRequest @event)
        {
            return new EventTest.Models.Event
            {
                Id = Guid.NewGuid(),
                Title = @event.Title,
                Tickets = @event.Tickets,
                Venue = @event.Venue,
                StartDateTime = @event.StartDateTime,
                EndDateTime = @event.EndDateTime,
                LastModifiedDateTime = DateTimeOffset.Now,
                Description = @event.Description
            };
        }
    }
}