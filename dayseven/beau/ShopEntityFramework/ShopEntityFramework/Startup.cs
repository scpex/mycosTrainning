using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopEntityFramework.Startup))]
namespace ShopEntityFramework
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
