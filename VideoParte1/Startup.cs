using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoParte1.Startup))]
namespace VideoParte1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
