using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBArticles.Startup))]
namespace DBArticles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
