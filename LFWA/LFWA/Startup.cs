using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFWA.Startup))]
namespace LFWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
