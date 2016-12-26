using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PriceCalculation.Models;

namespace PriceCalculation.ViewModel
{
    public class ProductStateViewModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
        public IEnumerable<StateTaxesModel> States { get; set; }
    }
}