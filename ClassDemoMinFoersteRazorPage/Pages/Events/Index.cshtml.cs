using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoMinFoersteRazorPage.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoMinFoersteRazorPage.Pages.Events
{
    public class IndexModel : PageModel
    {
        private FakeEventCatalog catalog;

        // properties til view
        public List<Event> Events { get; private set; }

        public IndexModel()
        {
            catalog = new FakeEventCatalog();
        }

        public void OnGet()
        {
            Events = catalog.GetAllEvents();

        }
    }
}
