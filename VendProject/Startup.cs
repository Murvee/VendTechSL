using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VendProject.Startup))]
namespace VendProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
