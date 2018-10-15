using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Estacionamiento.Startup))]
namespace Estacionamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
