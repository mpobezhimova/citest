using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CITest.Startup))]
namespace CITest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
