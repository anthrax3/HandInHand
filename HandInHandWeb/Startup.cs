using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandInHandWeb.Startup))]
namespace HandInHandWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
