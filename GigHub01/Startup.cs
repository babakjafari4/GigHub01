using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigHub01.Startup))]
namespace GigHub01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
