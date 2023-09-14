using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CTVisionCluu.Startup))]
namespace CTVisionCluu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
