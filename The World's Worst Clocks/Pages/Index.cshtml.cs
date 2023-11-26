using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace The_World_s_Worst_Clocks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        //var timeout = SetTimeout(() =>
        //{
        public string TimeColour { get; set; } = "PageModel in C#";

        public string RGBHours { get; set; } = DateTime.Now.TimeOfDay.Hours.ToString();
        public int RGBRed { get; set; } = 1;
        public string RGBMinutes { get; set; } = DateTime.Now.TimeOfDay.Minutes.ToString();
        public int RGBGreen { get; set; } = 1;
        public string RGBSeconds { get; set; } = DateTime.Now.TimeOfDay.Seconds.ToString();
        public int RGBBlue { get; set; } = 1;

        private static double pi = Math.PI;

        public string piString = pi.ToString();

        public string timeIndexInPi;
        //}, 2000);


        public void OnGet()
        {



            TimeColour += $"Server time is {DateTime.Now}";

            RGBRed = Int32.Parse(RGBHours) * 10;

            RGBRed = RGBRed;

            RGBGreen = Int32.Parse(RGBMinutes) * 4;

            RGBGreen = RGBGreen;

            RGBBlue = RGBBlue = Int32.Parse(RGBSeconds) * 4;

            RGBBlue = RGBBlue;

            timeIndexInPi = piString.ToString().IndexOf((DateTime.Now.TimeOfDay.Seconds % 10).ToString()).ToString();

            piString = piString;


            //ClearTimeout(timeout);


        }




        public CancellationTokenSource SetTimeout(Action action, int millis)
        {

            var cts = new CancellationTokenSource();
            var ct = cts.Token;
            _ = Task.Run(() =>
            {
                Thread.Sleep(millis);
                if (!ct.IsCancellationRequested)
                    action();
            }, ct);

            return cts;
        }

        //public void ClearTimeout(CancellationTokenSource cts)
        //{
        //    cts.Cancel();
        //}


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
