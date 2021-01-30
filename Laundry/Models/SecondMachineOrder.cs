using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laundry.Models
{
    public class SecondMachineOrder
    {
        [Key] public int id { get; set; }
        public string clientName { get; set; }
        public string clientSurname { get; set; }
        public string clientNumber { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public int machineNumber { get; set; }

        public SecondMachineOrder(string name, string surname, string number, string date, string time, int machineNumber)
        {
            this.clientName = name;
            this.clientSurname = surname;
            this.clientNumber = number;
            this.date = date;
            this.time = time;
            this.machineNumber = 2;
        }
        public SecondMachineOrder()
        {

        }


    }
}

