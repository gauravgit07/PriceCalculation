using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PriceCalculation.Startup))]
namespace PriceCalculation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
