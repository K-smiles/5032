using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT_5032MyViewModel.Startup))]
namespace FIT_5032MyViewModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
