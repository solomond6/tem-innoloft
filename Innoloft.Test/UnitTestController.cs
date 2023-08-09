using Innoloft.Controllers;
using Innoloft.Models;
using Innoloft.Services;
using Moq;

namespace Innoloft.Test
{
    public class UnitTestController
    {
        private readonly Mock<IEventService> eventService;
        public UnitTestController()
        {
            eventService = new Mock<IEventService>();
        }

        [Fact]
        public void GetEventList_EventList()
        {
            //arrange
            var eventList = GetEventsData();
            eventService.Setup(x => x.GetEventList())
                .Returns(eventList);

            EventController eventController = new EventController(eventService.Object);

            //act
            var eventResult = eventController.GetEvents();

            //assert
            Assert.NotNull(eventResult);
            Assert.Equal(GetEventsData().Count(), eventResult.Result.Count());
            Assert.Equal(GetEventsData().ToString(), eventResult.Result.ToString());
            Assert.True(eventList.Equals(eventResult.Result));
        }


        [Fact]
        public void GetEventByID_Event()
        {
            //arrange
            var eventList = GetEventsData();
            eventService.Setup(x => x.GetEventById(2))
                .Returns(eventList[1]);

            EventController eventController = new EventController(eventService.Object);

            //act
            var eventResult = eventController.GetEvents(2);

            //assert
            Assert.NotNull(eventResult);
            Assert.Equal(eventList[1].Id, eventResult.Result.Value.Id);
            Assert.True(eventList[1].Id == eventResult.Result.Value.Id);
        }

        [Fact]
        public void AddEvent_Event()
        {
            //arrange
            var eventList = GetEventsData();
            eventService.Setup(x => x.AddEvent(eventList[2]))
                .Returns(eventList[2]);

            EventController eventController = new EventController(eventService.Object);

            //act
            var eventResult = eventController.PostEvents(eventList[2]);

            //assert
            Assert.NotNull(eventResult);
            Assert.Equal(eventList[2].Id, eventResult.Result.Value.Id);
            Assert.True(eventList[2].Id == eventResult.Result.Value.Id);
        }

        private List<Event> GetEventsData()
        {
            List<Event> eventData = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Title = "Sample 1",
                    Description = "Sample 1",
                    TimezoneId = 0,
                    CreatedBy = 0,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Event
                {
                    Id = 2,
                    Title = "Sample 2",
                    Description = "Sample 2",
                    TimezoneId = 0,
                    CreatedBy = 0,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
                new Event
                {
                    Id = 3,
                    Title = "Sample 3",
                    Description = "Sample 3",
                    TimezoneId = 0,
                    CreatedBy = 0,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                },
            };
            return eventData;
        }
    }
}