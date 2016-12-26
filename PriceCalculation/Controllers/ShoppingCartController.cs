using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PriceCalculation.Models;
using PriceCalculation.DAL;

namespace PriceCalculation.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly PriceCalculationContext _priceCalculation;
        
        public ShoppingCartController(PriceCalculationContext PriceCalculationContext)
        {
            _priceCalculation = PriceCalculationContext;
        }
        public ActionResult Index()
        {
            return View();
        }

        public int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.Id == id)
                    return i;
            return -1;
        }


        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }

        public ActionResult Update(FormCollection fc)
        {
            string[] quantities = fc.GetValues("quantity");
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                cart[i].Quantity = Convert.ToInt32(quantities[i]);
            Session["cart"] = cart;
                return View("Cart");
        }

        public ActionResult OrderNow(int id)
        {
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Controllers.Item(_priceCalculation.Product.Find(id),1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Controllers.Item(_priceCalculation.Product.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
       
    }
}