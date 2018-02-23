using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sayvin.Startup))]
namespace Sayvin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
