using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eLGU_eBOSS.Startup))]
namespace eLGU_eBOSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
