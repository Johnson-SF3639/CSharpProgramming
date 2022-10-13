using System;
namespace Event{
    class Program{
        public static void Main(string[] args)
        {

            Events event1 = new Events("Quiz");
            Events event2 = new Events("Debugging");
            Events event3 = new Events("Presentation");
            Events event4 = new Events("Games");

            //add event
            Events.eventlink += new EventManager(event1.ShowEvent);
            Events.eventlink += new EventManager(event2.ShowEvent);
            Events.eventlink += new EventManager(event3.ShowEvent);
            Events.eventlink += new EventManager(event4.ShowEvent);

            //show event
            Events.HandleEvent();

            //cancel Event
            Events.eventlink -= new EventManager(event3.ShowEvent);

            Events.HandleEvent();

        }
    }
}