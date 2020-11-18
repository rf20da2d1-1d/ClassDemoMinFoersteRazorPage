using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoMinFoersteRazorPage.interfaces;
using ClassDemoMinFoersteRazorPage.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoMinFoersteRazorPage.Pages.Events
{
    public class IndexModel : PageModel
    {
        private IFakeEventCatalog _catalog;

        // properties til view
        public List<Event> Events { get; private set; }

        [BindProperty]
        public String  FilterCriteria { get; set; }

        public IndexModel(IFakeEventCatalog diCatalog)
        {
            _catalog = diCatalog;
        }

        public void OnGet()
        {
            Events = _catalog.GetAllEvents();

        }

        public void OnPost()
        {
            // tjekker lige at filter er sat
            if (string.IsNullOrWhiteSpace(FilterCriteria))
            {
                Events = _catalog.GetAllEvents();
            }
            else
            {
                Events = _catalog.GetByFilter(FilterCriteria);
            }


        }
    }
}
