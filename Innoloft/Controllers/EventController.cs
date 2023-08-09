using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Innoloft.Data;
using Innoloft.Models;
using Innoloft.Services;

namespace Innoloft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {

        private readonly IEventService eventService;
        public EventController(IEventService _eventService)
        {
            eventService = _eventService;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await Task.FromResult(eventService.GetEventList());
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvents(int id)
        {
            return await Task.FromResult(eventService.GetEventById(id));
        }

        // PUT: api/Events/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Event>> PutEvents(int id, Event _event)
        {
            if (id != _event.Id)
            {
                return BadRequest();
            }

            return await Task.FromResult(eventService.UpdateEvent(_event));

        }

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvents(Event _event)
        {
            return await Task.FromResult(eventService.AddEvent(_event));
        }

        // DELETE: api/Events/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteEvents(int id)
        {
            return await Task.FromResult(eventService.DeleteEvent(id));
        }

    }
}
