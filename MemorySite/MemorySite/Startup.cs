using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemorySite.Startup))]
namespace MemorySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
