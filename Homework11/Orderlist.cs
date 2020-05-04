using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Orderlist : DbContext
    {
        public Orderlist() : base("Order")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<Orderlist>());
        }
        public DbSet<Order>Orders{get;set;}
        public DbSet<OrderItem>OrderItems{get;set;}
    }
}
