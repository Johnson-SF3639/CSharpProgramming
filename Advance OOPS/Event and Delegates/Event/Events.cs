using System;

namespace Event
{
    public delegate void EventManager();
    public class Events
    {
        public static event EventManager eventlink=null;
        static int i;
        private string _eventName;


        public Events(string eventName){
            _eventName=eventName;
        }
        public static void HandleEvent(){
            i=0;
            Console.WriteLine($"User Registration");
            Console.WriteLine($"Staring the following events");
            eventlink();
        }

        public void ShowEvent(){
            ++i;
            Console.WriteLine($"Event No : {i} is : {_eventName} Started");
        }

    }
}