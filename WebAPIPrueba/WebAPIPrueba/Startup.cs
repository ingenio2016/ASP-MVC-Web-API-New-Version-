using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAPIPrueba.Startup))]
namespace WebAPIPrueba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
