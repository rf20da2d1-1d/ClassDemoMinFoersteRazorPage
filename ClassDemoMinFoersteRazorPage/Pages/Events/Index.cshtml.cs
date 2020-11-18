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

        [BindProperty]
        public String  FilterCriteria { get; set; }

        public IndexModel()
        {
            catalog = FakeEventCatalog.Instance;
        }

        public void OnGet()
        {
            Events = catalog.GetAllEvents();

        }

        public void OnPost()
        {
            // tjekker lige at filter er sat
            if (string.IsNullOrWhiteSpace(FilterCriteria))
            {
                Events = catalog.GetAllEvents();
            }
            else
            {
                Events = catalog.GetByFilter(FilterCriteria);
            }


        }
    }
}
