using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PriceCalculation.Models;

namespace PriceCalculation.DAL
{
    public class PriceCalculationContext:DbContext
    {
        //public PriceCalculationContext() : base("PriceCalculationContext")
        //{

        //}
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<StateTaxesModel> StateTax { get; set; }


    }
}