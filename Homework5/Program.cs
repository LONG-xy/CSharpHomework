using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5
{



    public class OrderItem
    {
        public string OrderID { get; }//订单号
        public string OrderState { get; }//订单状态
        public string CommodityName { get; set; }
        public double CommodityPrice { get; set; }
        public int OrderQuantity { get; set; }
        public double Sum { get; }
        public OrderItem(string orderid, string commodityname, double commodityprice, int orderquantity, string orderstate)
        {
            OrderID = orderid;
            CommodityName = commodityname;
            CommodityPrice = commodityprice;
            OrderQuantity = orderquantity;
            OrderState = orderstate;
            Sum = commodityprice * orderquantity;
        }
    }


    public class Order
    {

        public string Customer { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public OrderItem orderitem;

        public Order(string customer, string phonenumber, string address, OrderItem orderitem)//构造Order
        {
            Customer = customer;
            PhoneNumber = phonenumber;
            CustomerAddress = address;
        }

        public override string ToString()
        {
            return Customer + '\t' + orderitem.ToString();
        }

        public override bool Equals(object obj)
        {
            var order = obj as OrderItem;
            return orderitem.OrderID == orderitem.OrderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



        public class OrderSercive
        {
            List<OrderItem> orderlist = new List<OrderItem>();


            public void AddOrder(List<OrderItem> ordrlist, OrderItem orderitem) 
            {
                orderlist.Add(orderitem);
            }


            public void UpdateOrder(List<OrderItem> orderlist,string id,string commodityname, int orderquatity)
            {
                var result = from x in orderlist where id == x.OrderID select x;
                List<OrderItem> order_search = result.ToList();
                int index = orderlist.FindIndex(x => x.OrderID == id);
                orderlist.RemoveAt(index);
                order_search[Int32.Parse(id)].OrderQuantity = orderquatity;
                order_search[Int32.Parse(id)].CommodityName = commodityname;


            }

            public bool DeleteOrder(List<OrderItem> orderlist, string id)
            {
                bool flag = true;
                try 
                { 
                int index = orderlist.FindIndex(x => x.OrderID == id);
                    orderlist.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    flag = false;
                    Console.WriteLine(ex.ToString());

                }
                return flag;
            }

        }

        public class Search
        {
            public static List<OrderItem> SearchID(List<OrderItem> orderlist, string id)
            {
                var result = from x in orderlist where x.OrderID == id select x;
                List<OrderItem> order_search = result.ToList();
                return order_search;
            }
            public static List<OrderItem> SearchCommodity(List<OrderItem> orderlist, string commodityname)
            {
                var result = from x in orderlist where x.CommodityName == commodityname select x;
                List<OrderItem> order_search = result.ToList();
                return order_search;
            }

            public static List<OrderItem> SearchOrderlist(List<OrderItem> orderlist)
            {
                var result = from x in orderlist orderby x.Sum descending select x;
                List<OrderItem> order_search = result.ToList();
                return order_search;

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}

