using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject.Web.Common;
using PriceCalculation.Models;
using PriceCalculation.DAL;

namespace PriceCalculation.App_Start
{
    public class PriceCalculationNinject : NinjectModule
    {
        public override void Load()
        {
            Bind<PriceCalculationContext>().ToSelf().InRequestScope();
        }
    }
}