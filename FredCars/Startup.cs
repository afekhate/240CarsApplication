using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FredCars.Startup))]
namespace FredCars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
