namespace EventTest.Contracts.EventTest;

public record EventTestResponse(
    Guid Id,
    string? Title,
    int Tickets,
    string? Venue,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTimeOffset LastModifiedDateTime,
    List<string>? Description);