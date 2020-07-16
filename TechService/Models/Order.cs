﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechService
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Good_Id { get; set; }
        public decimal Price { get; set; }

        public Order() { }
        public Order(int OrderId_, int Good_Id_, decimal Price_)
        {
            this.OrderId = OrderId_;
            this.Good_Id = Good_Id_;
            this.Price = Price_;
        }

        public virtual IEnumerable<Good> Goods { get; set; }
    }

}