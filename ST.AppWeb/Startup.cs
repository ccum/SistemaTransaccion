using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ST.AppWeb.Startup))]
namespace ST.AppWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
