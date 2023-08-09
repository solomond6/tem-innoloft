using Innoloft.Data;
using Innoloft.Models;
using Microsoft.EntityFrameworkCore;

namespace Innoloft.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _dbContext;

        public EventService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Event AddEvent(Event _event)
        {
            var result = _dbContext.Events.Add(_event);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public bool DeleteEvent(int Id)
        {
            var filteredData = _dbContext.Events.Where(x => x.Id == Id).FirstOrDefault();
            var result = _dbContext.Remove(filteredData);
            _dbContext.SaveChanges();
            return result != null ? true : false;
        }

        public Event GetEventById(int id)
        {
            return _dbContext.Events.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Event> GetEventList()
        {
            return _dbContext.Events.ToList();
        }

        public Event UpdateEvent(Event _event)
        {
            var result = _dbContext.Events.Update(_event);
            _dbContext.SaveChanges();
            return result.Entity;
        }

        public IEnumerable<EventRegistration> GetEventregistrationList()
        {
            return _dbContext.EventRegistration.ToList();
        }

        public EventRegistration GetEventRegistrationById(int id)
        {
            return _dbContext.EventRegistration.Where(x => x.Id == id).FirstOrDefault();
        }

        public EventRegistration CreateEventRegistration(EventRegistration _eventReg)
        {
            var result = _dbContext.EventRegistration.Update(_eventReg);
            _dbContext.SaveChanges();
            return result.Entity;
        }
        
    }
}
