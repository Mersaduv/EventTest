namespace EventTest.Models;

public class Event
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int Tickets { get; set; }
    public string? Venue { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public DateTimeOffset LastModifiedDateTime { get; set; }
    public List<string>? Description { get; set; }
}