using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Order
    {
        public int orderID { get; set; }
        [Required]
        public string custom_name { get; set; }//自动识别为主键
        public string custom_address { get; set; }
        public string custom_telephone { get; set; }
        public List<OrderItem> OrderItems { get; set; }//一对多关联

    }

    public class OrderItem
    {
        public int goodsID { get; set; }////自动识别为主键
        [Required]
        public string good_name { get; set; }
        public int good_quality { get; set; }
        public double good_price { get; set;}

        public int orderID { get; set; }// 自动识别为外键

    }
}
