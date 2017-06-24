using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystroNews.Startup))]
namespace SystroNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
