using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthForms.Startup))]
namespace AuthForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
