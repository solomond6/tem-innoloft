using Innoloft.Models;

namespace Innoloft.Services
{
    public interface IEventService
    {
        public IEnumerable<Event> GetEventList();
        public Event GetEventById(int id);
        public Event AddEvent(Event _event);
        public Event UpdateEvent(Event _event);
        
        public bool DeleteEvent(int Id);

        public IEnumerable<EventRegistration> GetEventregistrationList();
        public EventRegistration GetEventRegistrationById(int id);
        public EventRegistration CreateEventRegistration(EventRegistration eventRegistration);
    }
}
