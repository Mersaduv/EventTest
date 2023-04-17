namespace EventTest.Contracts.EventTest;

public record CreateEventTestRequest(
    string title,
    int tickets,
    string venue,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> description);