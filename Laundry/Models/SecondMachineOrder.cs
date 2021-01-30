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
        public string ipAddress { get; set; }
        public SecondMachineOrder()
        {

        }


    }
}

