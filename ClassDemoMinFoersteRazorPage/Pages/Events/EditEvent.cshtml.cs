using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ClassDemoMinFoersteRazorPage.Pages.Events
{
    public class EditEventModel : PageModel
    {
        public int EventId { get; set; }
        public IActionResult OnGet(int id)
        {
            EventId = id;
            return Page();
        }
    }
}
