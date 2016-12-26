using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriceCalculation.Models
{
    public class StateTaxesModel
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public decimal TaxRate { get; set; }
    }
}