using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoMinFoersteRazorPage.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoMinFoersteRazorPage.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private FakeEventCatalog repo;

        [BindProperty]
        public Event Event { get; set;  }

        public CreateEventModel()
        {
            repo = FakeEventCatalog.Instance;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
