using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order_Logger_API.Models
{
    public class OrderDetailContext : DbContext
    {
        public OrderDetailContext(DbContextOptions<OrderDetailContext> options) : base(options)
        {

        }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
