using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PriceCalculation.DAL;
using PriceCalculation.Models;
using PriceCalculation.ViewModel;

namespace PriceCalculation.Controllers
{
    
    public class ProductsController : Controller
    {
        private readonly PriceCalculationContext _priceCalculation;            
        public ProductsController(PriceCalculationContext PriceCalculationContext)
        {
            _priceCalculation = PriceCalculationContext;
        }

        public ActionResult Index()
        {
            ViewBag.listproducts = _priceCalculation.Product.ToList();            
            return View();
        }      
        
    }
}