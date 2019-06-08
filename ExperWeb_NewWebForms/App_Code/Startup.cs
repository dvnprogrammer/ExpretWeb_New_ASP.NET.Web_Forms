using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperWeb_NewWebForms.Startup))]
namespace ExperWeb_NewWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
