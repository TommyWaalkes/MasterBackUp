using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTest.Startup))]
namespace AzureTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
