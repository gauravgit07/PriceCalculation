using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PriceCalculation.Models;

namespace PriceCalculation.Controllers
{
    public class Item
    {
        private ProductModel product = new ProductModel();
        public  ProductModel Product
        {
            get { return product; }
            set { product = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Item()
        {

        }
        public Item(ProductModel product,int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}