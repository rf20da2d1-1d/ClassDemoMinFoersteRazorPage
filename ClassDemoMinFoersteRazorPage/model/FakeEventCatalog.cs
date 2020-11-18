using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDemoMinFoersteRazorPage.model
{
    // laves om til en singleton - altså kun EET objekt

    public class FakeEventCatalog
    {
        /*
         * Start på singleton
         *
         * 3 step
         * 1) laver konstruktør privat
         * 2) laver et objekt af klassen selv som et instans felt - static dvs på klassen
         * 3) laver en property til at hente et objekt - static dvs på klassen
         *
         */


        private static FakeEventCatalog _instance = new FakeEventCatalog();  // eager altså med det samme 

        public static FakeEventCatalog Instance { get { return _instance; } }


        /*
        public static FakeEventCatalog Instance
        {
            get
            {
                // kunne lave objektet her - lazy
                // første gang man skal bruge objektet
                if (_instance == null)
                {
                    _instance = new FakeEventCatalog();
                }

                return _instance;
            }
        }
        */
        

        private FakeEventCatalog()
        {
            events = new List<Event>();
            events.Add(new Event(10, "skole", "læser", "roskilde", DateTime.Now));
            events.Add(new Event(20, "skole1", "læser videre", "roskilde", DateTime.Now));
            events.Add(new Event(30, "skole2", "læser mere", "København", DateTime.Now));

        }

        /*
         * Færdig med singleton
         */


        private List<Event> events = null;


        public List<Event> GetAllEvents()
        {
            return events;
        }

        public void AddEvent(Event ev)
        {
            if (events.Count == 0) // no events in the list
            {
                ev.Id = 1;
            }
            else // find the next Id number
            {
                int maxIdSoFar = events.Max(e => e.Id);
                ev.Id = maxIdSoFar + 1;
            }

            // insert event with generated id in the list
            events.Add(ev);
        }

        public List<Event> GetByFilter(string filterCriteria)
        {
            List<Event> liste = new List<Event>();

            foreach (Event ev in events)
            {
                if (ev.City.ToLower().Contains(filterCriteria.ToLower()))
                {
                    liste.Add(ev);
                }

            }

            return liste;
        }
    }
}
