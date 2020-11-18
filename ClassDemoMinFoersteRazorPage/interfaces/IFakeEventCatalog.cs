using System.Collections.Generic;
using ClassDemoMinFoersteRazorPage.model;

namespace ClassDemoMinFoersteRazorPage.interfaces
{
    public interface IFakeEventCatalog
    {
        List<Event> GetAllEvents();
        void AddEvent(Event ev);
        List<Event> GetByFilter(string filterCriteria);
    }
}