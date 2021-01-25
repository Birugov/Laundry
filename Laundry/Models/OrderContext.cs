using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laundry.Models
{
    public class OrderContext:DbContext
    {
        public DbSet<FirstMachineOrder> firstMachineOrders { get; set; }
        public DbSet<SecondMachineOrder> secondMachineOrders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) :base(options)
        {
            Database.EnsureCreated();
        }

    }
}
