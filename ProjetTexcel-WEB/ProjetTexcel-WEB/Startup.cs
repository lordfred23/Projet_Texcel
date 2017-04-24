using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetTexcel_WEB.Startup))]
namespace ProjetTexcel_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
