using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LostandFound.Startup))]
namespace LostandFound
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
