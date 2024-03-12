using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductManagement_2.Startup))]
namespace ProductManagement_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
