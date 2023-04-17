namespace EventTest.Contracts.EventTest;

public record EventTestResponse(
    Guid Id,
    string title,
    int tickets,
    string venue,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string> description);