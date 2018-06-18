using Payment_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payment_MVC.Models
{
    public class Order
    {
        public class OrderItem
        {
            public string Item { get; set; }
            public int Num { get; set; }
            public double Price { get; set; }
        }
        public int OrderId { get; set; }
        public string DoB { get; set; }
        public int Total { get; set; }

        //public List<Order> OrderItems { get; set; } = new List<Order>
        //{
        //    new Order
        //    {
        //        OrderId = 1,
        //        DoB = "1980-02-23",
        //        Total = 11
        //    }
        //};

        //public List<OrderItem> OrderItemsAdditional { get; set; } = new List<OrderItem> 
        //{
        //    new OrderItem
        //    {
        //    Item = "Toy",
        //    Num = 1,
        //    Price = 10.0
        //    }
        //};
 
     }
}
    


