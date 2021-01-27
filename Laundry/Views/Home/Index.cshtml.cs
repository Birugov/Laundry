using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Laundry.Views.Home
{
    public class IndexModel : PageModel
    {
        public DateTime currentDate { get; set; }
        public DateTime maxDate { get; set; }

        public void OnGet()
        {
            currentDate = DateTime.Now;
            maxDate = currentDate.AddDays(60);
        }
    }
}
