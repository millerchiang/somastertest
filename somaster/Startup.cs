using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(somaster.Startup))]
namespace somaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
