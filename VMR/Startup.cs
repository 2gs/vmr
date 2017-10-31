using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMR.Startup))]
namespace VMR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
