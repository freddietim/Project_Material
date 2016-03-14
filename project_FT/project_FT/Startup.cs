using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_FT.Startup))]
namespace project_FT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
