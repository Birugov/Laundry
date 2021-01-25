using Laundry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laundry.Views.Home
{
    public partial class Index
    {
        protected void PageLoad(object sender, EventArgs e)
        {

        }
        public void DisplayTime()
        {

            string start_time = "9:00";

            string end_time = "22:00";

            int minutes = 60;

            List<TimeList> timelist = new List<TimeList>();

            DateTime startdatetime = Convert.ToDateTime(start_time);

            DateTime enddatetime = Convert.ToDateTime(end_time);
            TimeSpan timeinterval = enddatetime.Subtract(startdatetime);
            int totalminutes = Convert.ToInt32(timeinterval.TotalMinutes);
            int no_of_time_slote = totalminutes / minutes;

                for (int i=0; i<no_of_time_slote; i++)
            {
                TimeList obj = new TimeList();
                startdatetime = startdatetime.AddMinutes(minutes);
                obj.strtime = startdatetime.ToString("hh:mm tt");
                timelist.Add(obj);
            }

                
        }
    }
}
