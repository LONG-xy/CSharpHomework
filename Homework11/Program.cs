using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            //添加订单
            int newOrderID = 0;
            int newOrderItem = 0;
            using (var context = new Orderlist())
            {
                var order = new Order();
                order.custom_name = "susan";
                order.custom_address = "Green Road";
                order.custom_telephone = "12345678";

                context.Orders.Add(order);
                context.SaveChanges();
                newOrderID = order.orderID;
            }
            //添加订单明细
            using (var context = new Orderlist())
            {
                var orderItem = new OrderItem();
                context.Entry(orderItem).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                newOrderItem = orderItem.orderID;

            }

            //查找订单
            using (var context = new Orderlist())
            {
                var order = context.Orders
                    .SingleOrDefault(b => b.orderID == newOrderID);
                if (order != null)
                    Console.WriteLine(order.OrderItems);

            }

            //修改订单
            using (var context = new Orderlist())
            {
                var orderItem = context.OrderItems.FirstOrDefault(p => p.orderID == newOrderID);
                if (orderItem != null)
                {
                    orderItem.good_name = "cake";
                    orderItem.good_quality = 3;
                    context.SaveChanges();

                }
            }
            //删除订单
            using (var context = new Orderlist())
            {
                var order = context.Orders.Include("orders").FirstOrDefault(p => p.orderID == newOrderID);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }
    }
}
