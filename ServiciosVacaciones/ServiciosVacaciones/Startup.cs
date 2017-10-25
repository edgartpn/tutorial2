using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiciosVacaciones.Startup))]
namespace ServiciosVacaciones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
