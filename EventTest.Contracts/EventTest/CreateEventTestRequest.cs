namespace EventTest.Contracts.EventTest;

public record CreateEventTestRequest(
    string Title,
    int Tickets,
    string Venue,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Description);