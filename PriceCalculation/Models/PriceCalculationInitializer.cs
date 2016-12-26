using System;
using System.Collections.Generic;
using System.Data.Entity;
using PriceCalculation.Models;
using PriceCalculation.DAL;

namespace PriceCalculation.Models
{
    public class PriceCalculationInitializer : DropCreateDatabaseIfModelChanges<PriceCalculationContext>
    {
        protected override void Seed(PriceCalculationContext context)
        {
            var products = new List<ProductModel>
            {
                new ProductModel
                {  Description="Item1",
                    IsSelected=false,
                   Discount= true,
                    Price =100,
                     Quantity=1,
                      State="CA"
                },

                new ProductModel
                {  Description="Item2",
                    IsSelected=false,
                   Discount= true,
                    Price =100,
                     Quantity=1,
                      State="CA"
                },

                new ProductModel
                {  Description="Item3",
                    IsSelected=false,
                   Discount= false,
                    Price =100,
                     Quantity=1,
                      State="CA"
                }
            };
            products.ForEach(d => context.Product.Add(d));

            var stateTaxes = new List<StateTaxesModel>
            {
                new StateTaxesModel
                { StateName = "TX",
                  TaxRate =0
                },
                new StateTaxesModel
                { StateName = "FL",
                  TaxRate =0
                },
                new StateTaxesModel
                { StateName = "NJ",
                  TaxRate =5
                },
                new StateTaxesModel
                { StateName = "CA",
                  TaxRate =10
                }
            };
            stateTaxes.ForEach(s => context.StateTax.Add(s));
        }
    }
}