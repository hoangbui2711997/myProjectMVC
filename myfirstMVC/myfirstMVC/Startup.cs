using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myfirstMVC.Startup))]
namespace myfirstMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
