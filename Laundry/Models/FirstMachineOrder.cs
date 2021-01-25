using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laundry.Models
{
    public class FirstMachineOrder
    {
        public int id { get; set; }
        public string clientName { get; set; }
        public string clientSurname { get; set; }
        public DateTime reservationDate { get; set; }
        public int machineNumber { get; set; }

        public FirstMachineOrder()
        {
            machineNumber = 1;
        }

    }
}
