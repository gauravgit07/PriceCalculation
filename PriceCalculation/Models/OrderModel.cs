using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriceCalculation.Models
{
    public class OrderModel
    {
        public bool IsSelected { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool Discount { get; set; }
        public string State { get; set; }
    }
}