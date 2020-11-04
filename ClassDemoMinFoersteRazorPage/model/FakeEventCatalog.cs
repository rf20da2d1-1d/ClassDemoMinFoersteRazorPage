using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDemoMinFoersteRazorPage.model
{
    public class FakeEventCatalog
    {
        private List<Event> events = null;

        public FakeEventCatalog()
        {
            events = new List<Event>();
            events.Add(new Event(1, "skole", "læser", "roskilde", DateTime.Now));
            events.Add(new Event(2, "skole1", "læser videre", "roskilde", DateTime.Now));
            events.Add(new Event(3, "skole2", "læser mere", "København", DateTime.Now));

        }

        public List<Event> GetAllEvents()
        {
            return events;
        }
    }
}
