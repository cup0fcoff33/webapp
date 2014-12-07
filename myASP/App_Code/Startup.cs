using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myASP.Startup))]
namespace myASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
