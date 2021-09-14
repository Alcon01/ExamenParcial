using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenParcial.Startup))]
namespace ExamenParcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
