using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFT.Startup))]
namespace PFT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
