using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormularioJM_Prueba1.Startup))]
namespace FormularioJM_Prueba1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
