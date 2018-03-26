using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop1.Startup))]
namespace WebShop1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
