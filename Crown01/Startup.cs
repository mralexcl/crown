using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Crown01.Startup))]
namespace Crown01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
