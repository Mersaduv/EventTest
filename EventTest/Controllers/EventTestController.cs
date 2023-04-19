using EventTest.Contracts.EventTest;
using EventTest.Mappers;
using EventTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EventTest.Controllers;

[ApiController]
public class EventTestController : ControllerBase
{
    private readonly IEventRepository _eventRepository;

    public EventTestController(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }
    [HttpPost("/events")]
    public IActionResult CreateEventTest(CreateEventTestRequest request)
    {
        var @event = EventMapper.MapToEvent(request);
        var createdEvent = _eventRepository.AddEvent(@event);
        var response = EventMapper.MapToEventTestResponse(createdEvent);
        return Ok(response);
    }

    [HttpGet("/events/{id:guid}")]
    public IActionResult GetEventTest(Guid id)
    {
        var @event = _eventRepository.GetEvent(id);
        if (@event == null)
        {
            return NotFound();
        }
        var response = EventMapper.MapToEventTestResponse(@event);
        return Ok(response);
    }

    [HttpPut("/events/{id:guid}")]
    public IActionResult UpsertEventTest(Guid id, UpsertEventTestRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/events/{id:guid}")]
    public IActionResult DeleteEventTest(Guid id)
    {
        return Ok(id);
    }
}


// using EventTest.Contracts.EventTest;
// using Microsoft.AspNetCore.Mvc;

// namespace EventTest.Controllers;

// [ApiController]
// public class EventTestController : ControllerBase
// {
//     [HttpPost("/events")]
//     public IActionResult CreateEventTest(CreateEventTestRequest request)
//     {
//         return Ok(request);
//     }

//     [HttpGet("/events/{id:guid}")]
//     public IActionResult GetEventTest(Guid id)
//     {
//         return Ok(id);
//     }

//     [HttpPut("/events/{id:guid}")]
//     public IActionResult UpsertEventTest(Guid id, UpsertEventTestRequest request)
//     {
//         return Ok(request);
//     }

//     [HttpDelete("/events/{id:guid}")]
//     public IActionResult DeleteEventTest(Guid id)
//     {
//         return Ok(id);
//     }
// }
