using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GridDisplayClient.Startup))]
namespace GridDisplayClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
