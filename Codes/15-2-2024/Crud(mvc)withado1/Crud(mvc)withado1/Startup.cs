using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crud_mvc_withado1.Startup))]
namespace Crud_mvc_withado1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
