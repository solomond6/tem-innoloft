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
    public class EventRegistrationController : ControllerBase
    {

        private readonly IEventService eventService;
        public EventRegistrationController(IEventService _eventService)
        {
            eventService = _eventService;
        }

        // GET: api/EventRegistrations
        [HttpGet]
        public async Task<IEnumerable<EventRegistration>> GetEvents()
        {
            return await Task.FromResult(eventService.GetEventregistrationList());
        }

        // GET: api/EventRegistrations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventRegistration>> GetEvents(int id)
        {
            return await Task.FromResult(eventService.GetEventRegistrationById(id));
        }

        // POST: api/EventRegistrations
        [HttpPost]
        public async Task<ActionResult<EventRegistration>> PostEvents(EventRegistration _eventReg)
        {
            return await Task.FromResult(eventService.CreateEventRegistration(_eventReg));
        }

    }
}
