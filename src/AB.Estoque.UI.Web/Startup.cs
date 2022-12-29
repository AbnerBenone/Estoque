using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AB.Estoque.UI.Web.Startup))]
namespace AB.Estoque.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
