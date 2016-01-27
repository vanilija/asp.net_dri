using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drinago.Startup))]
namespace Drinago
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
