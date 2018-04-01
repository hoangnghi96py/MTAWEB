using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTAWEB.Startup))]
namespace MTAWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
