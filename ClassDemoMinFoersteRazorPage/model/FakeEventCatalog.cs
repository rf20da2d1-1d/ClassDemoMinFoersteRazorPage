﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoMinFoersteRazorPage.interfaces;

namespace ClassDemoMinFoersteRazorPage.model
{
    public class FakeEventCatalog: IFakeEventCatalog
    {
        

        public  FakeEventCatalog()
        {
            events = new List<Event>();
            events.Add(new Event(10, "skole", "læser", "roskilde", DateTime.Now));
            events.Add(new Event(20, "skole1", "læser videre", "roskilde", DateTime.Now));
            events.Add(new Event(30, "skole2", "læser mere", "København", DateTime.Now));

        }


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
