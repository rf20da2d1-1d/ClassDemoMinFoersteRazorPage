using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ClassDemoMinFoersteRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        // KUN til demo
        private static int counter = 0;

        // property til view
        public String Message { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Message = "Default";
        }

        public void OnGet()
        {
            Message = "Ny besked " + counter++;
        }
    }
}
