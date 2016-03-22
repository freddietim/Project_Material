using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_FTF.Startup))]
namespace Project_FTF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
