using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCNick.Startup))]
namespace MVCNick
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
