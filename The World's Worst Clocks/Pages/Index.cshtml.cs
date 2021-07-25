using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_World_s_Worst_Clocks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string TimeColour { get; set; } = "PageModel in C#";

        public void OnGet()
        {
            TimeColour += $"Server time is {DateTime.Now}";
        }





    }

    public class TimeColour
    {

        DateTime Date = DateTime.Now;

        public string DateString;

        public TimeColour()

        {
            DateString = Date.ToString();
        }




    }
}
