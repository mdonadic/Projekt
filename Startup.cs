using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PinWebForms.Startup))]
namespace PinWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
