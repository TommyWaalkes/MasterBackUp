using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab20.Startup))]
namespace Lab20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
