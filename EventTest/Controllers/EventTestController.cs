using EventTest.Contracts.EventTest;
using Microsoft.AspNetCore.Mvc;

namespace EventTest.Controllers;

[ApiController]
public class EventTestController : ControllerBase
{
    [HttpPost("/events")]
    public IActionResult CreateEventTest(CreateEventTestRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/events/{id:guid}")]
    public IActionResult GetEventTest(Guid id)
    {
        return Ok(id);
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
