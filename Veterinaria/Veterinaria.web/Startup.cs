using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Veterinaria.web.Startup))]
namespace Veterinaria.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
