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

        public string RGBHours { get; set; } = DateTime.Now.TimeOfDay.Hours.ToString();
        public int RGBRed { get; set; } = 1;
        public string RGBMinutes { get; set; } = DateTime.Now.TimeOfDay.Minutes.ToString();
        public int RGBGreen { get; set; } = 1;
        public String RGBSeconds { get; set; } = DateTime.Now.TimeOfDay.Seconds.ToString();
        public int RGBBlue { get; set; } = 1;

        public double pi = Math.PI;


        public void OnGet()
        {
            TimeColour += $"Server time is {DateTime.Now}";

            RGBRed = Int32.Parse(RGBHours) * 10;

            RGBRed = RGBRed;

            RGBGreen = Int32.Parse(RGBMinutes) * 4;

            RGBGreen = RGBGreen;

            RGBBlue = RGBBlue = Int32.Parse(RGBSeconds) * 4;

            RGBBlue = RGBBlue;

            pi = pi;
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
