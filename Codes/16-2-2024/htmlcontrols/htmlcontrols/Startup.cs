using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(htmlcontrols.Startup))]
namespace htmlcontrols
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
